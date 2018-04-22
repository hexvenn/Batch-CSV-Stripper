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
                var csvFiles = GetCSVFiles(inputDirectoryDialog.FileName);

                Log($"Found {csvFiles.Length} files in {inputDirectoryDialog.FileName}");

                if (csvFiles.Length > 0)
                {
                    var headers = GetCSVHeaders(csvFiles[0]);
                    Log($"File headers: {string.Join(" | ", headers)}");

                    PrepareDataGrid(headers);
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

        }

        private void Log(string text)
        {
            listBoxLog.Items.Add($"[{DateTime.Now.ToString("HH:mm")}]: {text}");
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
