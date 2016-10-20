namespace JeffSplit
{
    partial class FileSplitter
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dialGetFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFileSelected = new System.Windows.Forms.Label();
            this.txtMaxChunk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblSelectedPath = new System.Windows.Forms.Label();
            this.dialGetFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pbarSplitPct = new System.Windows.Forms.ProgressBar();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.tmrSeconds = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Split";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Input";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dialGetFile
            // 
            this.dialGetFile.InitialDirectory = "\\\\srv-bkexec\\sql backups\\";
            // 
            // lblFileSelected
            // 
            this.lblFileSelected.Location = new System.Drawing.Point(93, 12);
            this.lblFileSelected.Name = "lblFileSelected";
            this.lblFileSelected.Size = new System.Drawing.Size(282, 23);
            this.lblFileSelected.TabIndex = 2;
            this.lblFileSelected.Text = "(select a file)";
            this.lblFileSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxChunk
            // 
            this.txtMaxChunk.Location = new System.Drawing.Point(96, 48);
            this.txtMaxChunk.Name = "txtMaxChunk";
            this.txtMaxChunk.Size = new System.Drawing.Size(100, 20);
            this.txtMaxChunk.TabIndex = 3;
            this.txtMaxChunk.Leave += new System.EventHandler(this.txtMaxChunk_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Split Size:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Output";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblSelectedPath
            // 
            this.lblSelectedPath.Location = new System.Drawing.Point(97, 81);
            this.lblSelectedPath.Name = "lblSelectedPath";
            this.lblSelectedPath.Size = new System.Drawing.Size(266, 23);
            this.lblSelectedPath.TabIndex = 6;
            this.lblSelectedPath.Text = "(select a path)";
            this.lblSelectedPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbarSplitPct
            // 
            this.pbarSplitPct.Location = new System.Drawing.Point(12, 158);
            this.pbarSplitPct.Name = "pbarSplitPct";
            this.pbarSplitPct.Size = new System.Drawing.Size(363, 23);
            this.pbarSplitPct.Step = 5;
            this.pbarSplitPct.TabIndex = 7;
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(111, 124);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(49, 13);
            this.lblElapsed.TabIndex = 8;
            this.lblElapsed.Text = "00:00:00";
            this.lblElapsed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Elapsed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remaining";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(231, 124);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(49, 13);
            this.lblRemaining.TabIndex = 10;
            this.lblRemaining.Text = "00:00:00";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tmrSeconds
            // 
            this.tmrSeconds.Interval = 1000;
            this.tmrSeconds.Tick += new System.EventHandler(this.tmrSeconds_Tick);
            // 
            // FileSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.pbarSplitPct);
            this.Controls.Add(this.lblSelectedPath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxChunk);
            this.Controls.Add(this.lblFileSelected);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FileSplitter";
            this.Text = "File Splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog dialGetFile;
        private System.Windows.Forms.Label lblFileSelected;
        private System.Windows.Forms.TextBox txtMaxChunk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblSelectedPath;
        private System.Windows.Forms.FolderBrowserDialog dialGetFolder;
        private System.Windows.Forms.ProgressBar pbarSplitPct;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Timer tmrSeconds;
    }
}

