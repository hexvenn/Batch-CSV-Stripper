namespace Batch_CSV_Stripper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxInputDirectory = new System.Windows.Forms.TextBox();
            this.textBoxOutputDirectory = new System.Windows.Forms.TextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.buttonInputDirectory = new System.Windows.Forms.Button();
            this.buttonOutputDirectory = new System.Windows.Forms.Button();
            this.buttonStrip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 66);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(604, 71);
            this.dataGridView.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxInputDirectory
            // 
            this.textBoxInputDirectory.Location = new System.Drawing.Point(12, 13);
            this.textBoxInputDirectory.Name = "textBoxInputDirectory";
            this.textBoxInputDirectory.Size = new System.Drawing.Size(570, 20);
            this.textBoxInputDirectory.TabIndex = 1;
            // 
            // textBoxOutputDirectory
            // 
            this.textBoxOutputDirectory.Location = new System.Drawing.Point(12, 40);
            this.textBoxOutputDirectory.Name = "textBoxOutputDirectory";
            this.textBoxOutputDirectory.Size = new System.Drawing.Size(570, 20);
            this.textBoxOutputDirectory.TabIndex = 2;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 202);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(604, 134);
            this.listBoxLog.TabIndex = 3;
            // 
            // buttonInputDirectory
            // 
            this.buttonInputDirectory.Location = new System.Drawing.Point(588, 10);
            this.buttonInputDirectory.Name = "buttonInputDirectory";
            this.buttonInputDirectory.Size = new System.Drawing.Size(28, 23);
            this.buttonInputDirectory.TabIndex = 4;
            this.buttonInputDirectory.Text = "...";
            this.buttonInputDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonOutputDirectory
            // 
            this.buttonOutputDirectory.Location = new System.Drawing.Point(588, 40);
            this.buttonOutputDirectory.Name = "buttonOutputDirectory";
            this.buttonOutputDirectory.Size = new System.Drawing.Size(28, 20);
            this.buttonOutputDirectory.TabIndex = 5;
            this.buttonOutputDirectory.Text = "...";
            this.buttonOutputDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonStrip
            // 
            this.buttonStrip.Location = new System.Drawing.Point(12, 143);
            this.buttonStrip.Name = "buttonStrip";
            this.buttonStrip.Size = new System.Drawing.Size(604, 48);
            this.buttonStrip.TabIndex = 6;
            this.buttonStrip.Text = "Strip All";
            this.buttonStrip.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 348);
            this.Controls.Add(this.buttonStrip);
            this.Controls.Add(this.buttonOutputDirectory);
            this.Controls.Add(this.buttonInputDirectory);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.textBoxOutputDirectory);
            this.Controls.Add(this.textBoxInputDirectory);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "Batch CSV Stripper";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxInputDirectory;
        private System.Windows.Forms.TextBox textBoxOutputDirectory;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonInputDirectory;
        private System.Windows.Forms.Button buttonOutputDirectory;
        private System.Windows.Forms.Button buttonStrip;
    }
}

