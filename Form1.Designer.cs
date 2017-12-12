using System.Windows.Input;

namespace FileRenamer
{
    partial class FileRenamer
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
            this.progressBarOperationProgress = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.radioButtonAllFiles = new System.Windows.Forms.RadioButton();
            this.radioButtonPictures = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNewFilename = new System.Windows.Forms.Label();
            this.labelStartingIndex = new System.Windows.Forms.Label();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.labelOperationProgress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProgressValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarOperationProgress
            // 
            this.progressBarOperationProgress.BackColor = System.Drawing.Color.DimGray;
            this.progressBarOperationProgress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressBarOperationProgress.Location = new System.Drawing.Point(122, 328);
            this.progressBarOperationProgress.Margin = new System.Windows.Forms.Padding(0);
            this.progressBarOperationProgress.MarqueeAnimationSpeed = 1;
            this.progressBarOperationProgress.Name = "progressBarOperationProgress";
            this.progressBarOperationProgress.Size = new System.Drawing.Size(676, 23);
            this.progressBarOperationProgress.Step = 1;
            this.progressBarOperationProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarOperationProgress.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(120, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(203, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(120, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpenFolder);
                // add custom windowm moving logic
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseMove);
            this.splitContainer1.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseUp); 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonAllFiles);
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonPictures);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.labelMessage);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.labelNewFilename);
            this.splitContainer1.Panel2.Controls.Add(this.labelStartingIndex);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Size = new System.Drawing.Size(821, 290);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 5;
                // add custom window moving logic
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseDown);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseMove);
            this.splitContainer1.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseUp); 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Files in the folder:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(10, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 221);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 8;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFolder.Location = new System.Drawing.Point(10, 3);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(148, 23);
            this.buttonOpenFolder.TabIndex = 7;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = false;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // radioButtonAllFiles
            // 
            this.radioButtonAllFiles.AutoSize = true;
            this.radioButtonAllFiles.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonAllFiles.Location = new System.Drawing.Point(120, 100);
            this.radioButtonAllFiles.Name = "radioButtonAllFiles";
            this.radioButtonAllFiles.Size = new System.Drawing.Size(94, 17);
            this.radioButtonAllFiles.TabIndex = 12;
            this.radioButtonAllFiles.Text = "rename all files";
            this.radioButtonAllFiles.UseVisualStyleBackColor = true;
            // 
            // radioButtonPictures
            // 
            this.radioButtonPictures.AutoSize = true;
            this.radioButtonPictures.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPictures.Checked = true;
            this.radioButtonPictures.ForeColor = System.Drawing.Color.White;
            this.radioButtonPictures.Location = new System.Drawing.Point(120, 77);
            this.radioButtonPictures.Name = "radioButtonPictures";
            this.radioButtonPictures.Size = new System.Drawing.Size(122, 17);
            this.radioButtonPictures.TabIndex = 11;
            this.radioButtonPictures.TabStop = true;
            this.radioButtonPictures.Text = "rename only pictures";
            this.radioButtonPictures.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(329, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 21);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(3, 220);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(120, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(120, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rename Files";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNewFilename
            // 
            this.labelNewFilename.AutoSize = true;
            this.labelNewFilename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNewFilename.Location = new System.Drawing.Point(3, 13);
            this.labelNewFilename.Name = "labelNewFilename";
            this.labelNewFilename.Size = new System.Drawing.Size(72, 13);
            this.labelNewFilename.TabIndex = 6;
            this.labelNewFilename.Text = "new filename:";
            // 
            // labelStartingIndex
            // 
            this.labelStartingIndex.AutoSize = true;
            this.labelStartingIndex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStartingIndex.Location = new System.Drawing.Point(3, 41);
            this.labelStartingIndex.Name = "labelStartingIndex";
            this.labelStartingIndex.Size = new System.Drawing.Size(111, 13);
            this.labelStartingIndex.TabIndex = 5;
            this.labelStartingIndex.Text = "index starting position:";
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFolderPath.Location = new System.Drawing.Point(58, 9);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(112, 13);
            this.labelFolderPath.TabIndex = 6;
            this.labelFolderPath.Text = "<selected folder path>";
            // 
            // labelOperationProgress
            // 
            this.labelOperationProgress.AutoSize = true;
            this.labelOperationProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOperationProgress.Location = new System.Drawing.Point(21, 332);
            this.labelOperationProgress.Name = "labelOperationProgress";
            this.labelOperationProgress.Size = new System.Drawing.Size(99, 13);
            this.labelOperationProgress.TabIndex = 4;
            this.labelOperationProgress.Text = "Operation progress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Folder:";
            // 
            // labelProgressValue
            // 
            this.labelProgressValue.AutoSize = true;
            this.labelProgressValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelProgressValue.Location = new System.Drawing.Point(806, 333);
            this.labelProgressValue.Name = "labelProgressValue";
            this.labelProgressValue.Size = new System.Drawing.Size(24, 13);
            this.labelProgressValue.TabIndex = 8;
            this.labelProgressValue.Text = "0 %";
            // 
            // FileRenamer
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(845, 362);
            this.Controls.Add(this.labelProgressValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelOperationProgress);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.progressBarOperationProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileRenamer";
            this.Text = "File Renamer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileRenamer_MouseUp); 
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarOperationProgress;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelNewFilename;
        private System.Windows.Forms.Label labelStartingIndex;
        private System.Windows.Forms.Label labelOperationProgress;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProgressValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButtonAllFiles;
        private System.Windows.Forms.RadioButton radioButtonPictures;
    }
}

