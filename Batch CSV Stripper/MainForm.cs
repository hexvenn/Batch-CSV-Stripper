using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Batch_CSV_Stripper
{
    public partial class MainForm : Form
    {
        string[] csvFiles;

        public MainForm()
        {
            InitializeComponent();

            textBoxInputDirectory.SetWatermark("Input directory");
            textBoxOutputDirectory.SetWatermark("Output directory");
        }

        private void buttonInputDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog inputDirectoryDialog = new CommonOpenFileDialog();
            inputDirectoryDialog.IsFolderPicker = true;

            if (inputDirectoryDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxInputDirectory.Text = inputDirectoryDialog.FileName;
                csvFiles = GetCSVFiles(inputDirectoryDialog.FileName);

                Log($"Found {csvFiles.Length} files in {inputDirectoryDialog.FileName}");

                if (csvFiles.Length > 0)
                {
                    var headers = GetCSVHeaders(csvFiles[0]);
                    Log($"File structure: {string.Join(" | ", headers)}");

                    PrepareDataGrid(headers);

                    buttonStrip.Enabled = true;
                }
            }
        }

        private void buttonOutputDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog outputDirectoryDialog = new CommonOpenFileDialog();
            outputDirectoryDialog.IsFolderPicker = true;

            if (outputDirectoryDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxOutputDirectory.Text = outputDirectoryDialog.FileName;
            }
        }

        private void buttonStrip_Click(object sender, EventArgs e)
        {
            var filters = GetRow(0);
            var removes = GetRow(1).Select(o => o == "x").ToArray();

            string outputPath = textBoxOutputDirectory.Text;

            int fileNo = 0;

            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(
                delegate (object o, DoWorkEventArgs args)
                {
                    BackgroundWorker b = o as BackgroundWorker;

                    for (int i = 0; i < csvFiles.Length; i++)
                    {
                        b.ReportProgress(-1);

                        string newName = Path.GetFileNameWithoutExtension(csvFiles[i]);

                        if (checkBoxAppend.Checked)
                        {
                            newName += textBoxAppend.Text;
                        }

                        using (TextFieldParser parser = new TextFieldParser(csvFiles[i]))
                        {
                            using (StreamWriter writer = File.AppendText($@"{outputPath}\{newName}.csv"))
                            {
                                parser.TextFieldType = FieldType.Delimited;
                                parser.SetDelimiters(",");

                                var n = 0;
                                while (!parser.EndOfData)
                                {
                                    string[] fields = parser.ReadFields();

                                    List<String> strippedLine = new List<string>();
                                    bool remove = false;

                                    for (int j = 0; j < fields.Length; j++)
                                    {
                                        if (removes[j])
                                        {
                                            continue;
                                        }

                                        if (filters[j] == "")
                                        {
                                            strippedLine.Add(EncaseIfComma(fields[j]));
                                            continue;
                                        }

                                        if (filters[j] == "*")
                                        {
                                            if (fields[j] == "")
                                                remove = true;
                                            continue;
                                        }

                                        if (fields[j] != filters[j])
                                        {
                                            remove = true;
                                        }
                                    }

                                    if(!remove)
                                    writer.WriteLine(string.Join(",", strippedLine));

                                    n++;

                                    // Only update the progress every 1000 rows, otherwise the UI would be updated too often
                                    if(n%1000==0)
                                    b.ReportProgress(n);
                                }

                                b.ReportProgress(n);
                            }
                        }
                    }

                });

            bw.ProgressChanged += new ProgressChangedEventHandler(
                delegate (object o, ProgressChangedEventArgs args)
                {
                    if(args.ProgressPercentage==-1)
                    {
                        fileNo++;
                        Log($"[{fileNo}/{csvFiles.Length}] Processing file {csvFiles[fileNo-1]}...");
                        Log($"");
                    }
                    else
                    UpdateLastLogLine($"Processed {args.ProgressPercentage} lines...");
                });

            bw.RunWorkerAsync();
        }

        private string[] GetCSVFiles(string directoryPath)
        {
            return Directory.GetFiles(directoryPath, "*.csv");
        }

        private string[] GetCSVHeaders(string filePath)
        {
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                return parser.ReadFields();
            }
        }

        private void PrepareDataGrid(string[] headers)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            foreach (var name in headers)
            {
                dataGridView.Columns.Add(name, name);
            }

            dataGridView.Rows.Add();
            dataGridView.Rows[0].HeaderCell.Value = "Filter";
            dataGridView.Rows.Add();
            dataGridView.Rows[1].HeaderCell.Value = "Remove";
        }

        private string EncaseIfComma(string text)
        {
            if (text.Contains(","))
            {
                return "\"" + text + "\"";
            }

            return text;
        }

        private string[] GetRow(int row)
        {
            string[] cells = new string[dataGridView.Rows[row].Cells.Count];

            for (int i = 0; i < dataGridView.Rows[row].Cells.Count; i++)
            {
                cells[i] = dataGridView[i, row].Value == null ? "" : dataGridView[i, row].Value.ToString();
            }

            return cells;
        }

        private void Log(string text)
        {
            listBoxLog.Items.Add($"[{DateTime.Now:HH:mm}]: {text}");
            listBoxLog.TopIndex = listBoxLog.Items.Count - 1;
        }

        private void UpdateLastLogLine(string text)
        {
            listBoxLog.Items[listBoxLog.Items.Count - 1] = $"[{DateTime.Now:HH:mm}]: {text}";
            listBoxLog.TopIndex = listBoxLog.Items.Count - 1;
        }
    }

    public static class CueBanner
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(HandleRef hWnd, uint msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetWatermark(this Control ctl, string text)
        {
            const int EM_SETCUEBANNER = 0x1501;
            const int CB_SETCUEBANNER = 0x1703;

            IntPtr retainOnFocus = new IntPtr(1);
            uint msg = EM_SETCUEBANNER;
            if (ctl is ComboBox)
                msg = CB_SETCUEBANNER;

            SendMessage(new HandleRef(ctl, ctl.Handle), msg, retainOnFocus, text);
        }
    }
}
