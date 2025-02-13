namespace reader
{
    partial class textMasker
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkEnableMask = new System.Windows.Forms.CheckBox();
            this.trackBarMaskRatio = new System.Windows.Forms.TrackBar();
            this.lblMaskRatio = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaskRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(597, 50);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(24, 50);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(514, 355);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkEnableMask
            // 
            this.chkEnableMask.AutoSize = true;
            this.chkEnableMask.Location = new System.Drawing.Point(597, 98);
            this.chkEnableMask.Name = "chkEnableMask";
            this.chkEnableMask.Size = new System.Drawing.Size(145, 17);
            this.chkEnableMask.TabIndex = 2;
            this.chkEnableMask.Text = "Enable Random Masking";
            this.chkEnableMask.UseVisualStyleBackColor = true;
            this.chkEnableMask.CheckedChanged += new System.EventHandler(this.chkEnableMask_CheckedChanged);
            // 
            // trackBarMaskRatio
            // 
            this.trackBarMaskRatio.Location = new System.Drawing.Point(597, 163);
            this.trackBarMaskRatio.Maximum = 100;
            this.trackBarMaskRatio.Name = "trackBarMaskRatio";
            this.trackBarMaskRatio.Size = new System.Drawing.Size(145, 45);
            this.trackBarMaskRatio.TabIndex = 3;
            this.trackBarMaskRatio.Value = 20;
            this.trackBarMaskRatio.Scroll += new System.EventHandler(this.trackBarMaskRatio_Scroll);
            // 
            // lblMaskRatio
            // 
            this.lblMaskRatio.AutoSize = true;
            this.lblMaskRatio.Location = new System.Drawing.Point(594, 133);
            this.lblMaskRatio.Name = "lblMaskRatio";
            this.lblMaskRatio.Size = new System.Drawing.Size(74, 13);
            this.lblMaskRatio.TabIndex = 4;
            this.lblMaskRatio.Text = "Blocking ratio:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(597, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textMasker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMaskRatio);
            this.Controls.Add(this.trackBarMaskRatio);
            this.Controls.Add(this.chkEnableMask);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "textMasker";
            this.Text = "TextMasker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaskRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkEnableMask;
        private System.Windows.Forms.TrackBar trackBarMaskRatio;
        private System.Windows.Forms.Label lblMaskRatio;
        private System.Windows.Forms.Button btnSave;
    }
}

