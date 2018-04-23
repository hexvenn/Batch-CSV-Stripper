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
            this.textBoxInputDirectory = new System.Windows.Forms.TextBox();
            this.textBoxOutputDirectory = new System.Windows.Forms.TextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.buttonInputDirectory = new System.Windows.Forms.Button();
            this.buttonOutputDirectory = new System.Windows.Forms.Button();
            this.buttonStrip = new System.Windows.Forms.Button();
            this.checkBoxMerge = new System.Windows.Forms.CheckBox();
            this.checkBoxAppend = new System.Windows.Forms.CheckBox();
            this.textBoxAppend = new System.Windows.Forms.TextBox();
            this.checkBoxHeader = new System.Windows.Forms.CheckBox();
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
            this.dataGridView.RowHeadersWidth = 80;
            this.dataGridView.Size = new System.Drawing.Size(760, 100);
            this.dataGridView.TabIndex = 0;
            // 
            // textBoxInputDirectory
            // 
            this.textBoxInputDirectory.Location = new System.Drawing.Point(12, 13);
            this.textBoxInputDirectory.Name = "textBoxInputDirectory";
            this.textBoxInputDirectory.Size = new System.Drawing.Size(726, 20);
            this.textBoxInputDirectory.TabIndex = 1;
            // 
            // textBoxOutputDirectory
            // 
            this.textBoxOutputDirectory.Location = new System.Drawing.Point(12, 40);
            this.textBoxOutputDirectory.Name = "textBoxOutputDirectory";
            this.textBoxOutputDirectory.Size = new System.Drawing.Size(726, 20);
            this.textBoxOutputDirectory.TabIndex = 2;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 233);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(760, 121);
            this.listBoxLog.TabIndex = 3;
            // 
            // buttonInputDirectory
            // 
            this.buttonInputDirectory.Location = new System.Drawing.Point(744, 13);
            this.buttonInputDirectory.Name = "buttonInputDirectory";
            this.buttonInputDirectory.Size = new System.Drawing.Size(28, 21);
            this.buttonInputDirectory.TabIndex = 4;
            this.buttonInputDirectory.Text = "...";
            this.buttonInputDirectory.UseVisualStyleBackColor = true;
            this.buttonInputDirectory.Click += new System.EventHandler(this.buttonInputDirectory_Click);
            // 
            // buttonOutputDirectory
            // 
            this.buttonOutputDirectory.Location = new System.Drawing.Point(744, 40);
            this.buttonOutputDirectory.Name = "buttonOutputDirectory";
            this.buttonOutputDirectory.Size = new System.Drawing.Size(28, 20);
            this.buttonOutputDirectory.TabIndex = 5;
            this.buttonOutputDirectory.Text = "...";
            this.buttonOutputDirectory.UseVisualStyleBackColor = true;
            this.buttonOutputDirectory.Click += new System.EventHandler(this.buttonOutputDirectory_Click);
            // 
            // buttonStrip
            // 
            this.buttonStrip.Enabled = false;
            this.buttonStrip.Location = new System.Drawing.Point(12, 195);
            this.buttonStrip.Name = "buttonStrip";
            this.buttonStrip.Size = new System.Drawing.Size(760, 32);
            this.buttonStrip.TabIndex = 6;
            this.buttonStrip.Text = "Strip All";
            this.buttonStrip.UseVisualStyleBackColor = true;
            this.buttonStrip.Click += new System.EventHandler(this.buttonStrip_Click);
            // 
            // checkBoxMerge
            // 
            this.checkBoxMerge.AutoSize = true;
            this.checkBoxMerge.Enabled = false;
            this.checkBoxMerge.Location = new System.Drawing.Point(12, 172);
            this.checkBoxMerge.Name = "checkBoxMerge";
            this.checkBoxMerge.Size = new System.Drawing.Size(89, 17);
            this.checkBoxMerge.TabIndex = 7;
            this.checkBoxMerge.Text = "Merge output";
            this.checkBoxMerge.UseVisualStyleBackColor = true;
            // 
            // checkBoxAppend
            // 
            this.checkBoxAppend.AutoSize = true;
            this.checkBoxAppend.Checked = true;
            this.checkBoxAppend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAppend.Location = new System.Drawing.Point(535, 172);
            this.checkBoxAppend.Name = "checkBoxAppend";
            this.checkBoxAppend.Size = new System.Drawing.Size(131, 17);
            this.checkBoxAppend.TabIndex = 8;
            this.checkBoxAppend.Text = "Append to filename(s):";
            this.checkBoxAppend.UseVisualStyleBackColor = true;
            // 
            // textBoxAppend
            // 
            this.textBoxAppend.Location = new System.Drawing.Point(672, 170);
            this.textBoxAppend.Name = "textBoxAppend";
            this.textBoxAppend.Size = new System.Drawing.Size(100, 20);
            this.textBoxAppend.TabIndex = 9;
            this.textBoxAppend.Text = "_stripped";
            // 
            // checkBoxHeader
            // 
            this.checkBoxHeader.AutoSize = true;
            this.checkBoxHeader.Enabled = false;
            this.checkBoxHeader.Location = new System.Drawing.Point(107, 172);
            this.checkBoxHeader.Name = "checkBoxHeader";
            this.checkBoxHeader.Size = new System.Drawing.Size(135, 17);
            this.checkBoxHeader.TabIndex = 10;
            this.checkBoxHeader.Text = "Copy header only once";
            this.checkBoxHeader.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 366);
            this.Controls.Add(this.checkBoxHeader);
            this.Controls.Add(this.textBoxAppend);
            this.Controls.Add(this.checkBoxAppend);
            this.Controls.Add(this.checkBoxMerge);
            this.Controls.Add(this.buttonStrip);
            this.Controls.Add(this.buttonOutputDirectory);
            this.Controls.Add(this.buttonInputDirectory);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.textBoxOutputDirectory);
            this.Controls.Add(this.textBoxInputDirectory);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Batch CSV Stripper";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxInputDirectory;
        private System.Windows.Forms.TextBox textBoxOutputDirectory;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonInputDirectory;
        private System.Windows.Forms.Button buttonOutputDirectory;
        private System.Windows.Forms.Button buttonStrip;
        private System.Windows.Forms.CheckBox checkBoxMerge;
        private System.Windows.Forms.CheckBox checkBoxAppend;
        private System.Windows.Forms.TextBox textBoxAppend;
        private System.Windows.Forms.CheckBox checkBoxHeader;
    }
}

