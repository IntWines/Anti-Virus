namespace Anti_Virus
{
    partial class frmVCKS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVCKS));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblVirus = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSikker = new System.Windows.Forms.Label();
            this.pctVirus = new System.Windows.Forms.PictureBox();
            this.pctNoVirus = new System.Windows.Forms.PictureBox();
            this.pctNeutral = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNeutral)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(231, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 199);
            this.listBox1.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(326, 277);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(52, 50);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScan.BackgroundImage")));
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Location = new System.Drawing.Point(377, 277);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(52, 50);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblVirus
            // 
            this.lblVirus.AutoSize = true;
            this.lblVirus.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVirus.Location = new System.Drawing.Point(126, 239);
            this.lblVirus.Name = "lblVirus";
            this.lblVirus.Size = new System.Drawing.Size(0, 13);
            this.lblVirus.TabIndex = 4;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFolder.Location = new System.Drawing.Point(19, 195);
            this.lblFolder.MaximumSize = new System.Drawing.Size(130, 30);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(42, 13);
            this.lblFolder.TabIndex = 5;
            this.lblFolder.Text = "[Folder]";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 255);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // lblSikker
            // 
            this.lblSikker.AutoSize = true;
            this.lblSikker.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSikker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSikker.Location = new System.Drawing.Point(19, 237);
            this.lblSikker.MaximumSize = new System.Drawing.Size(100, 15);
            this.lblSikker.MinimumSize = new System.Drawing.Size(50, 15);
            this.lblSikker.Name = "lblSikker";
            this.lblSikker.Size = new System.Drawing.Size(50, 15);
            this.lblSikker.TabIndex = 7;
            this.lblSikker.Text = "[Results]";
            // 
            // pctVirus
            // 
            this.pctVirus.Image = ((System.Drawing.Image)(resources.GetObject("pctVirus.Image")));
            this.pctVirus.Location = new System.Drawing.Point(12, 38);
            this.pctVirus.Name = "pctVirus";
            this.pctVirus.Size = new System.Drawing.Size(163, 131);
            this.pctVirus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctVirus.TabIndex = 8;
            this.pctVirus.TabStop = false;
            // 
            // pctNoVirus
            // 
            this.pctNoVirus.Image = ((System.Drawing.Image)(resources.GetObject("pctNoVirus.Image")));
            this.pctNoVirus.Location = new System.Drawing.Point(12, 38);
            this.pctNoVirus.Name = "pctNoVirus";
            this.pctNoVirus.Size = new System.Drawing.Size(163, 131);
            this.pctNoVirus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctNoVirus.TabIndex = 9;
            this.pctNoVirus.TabStop = false;
            // 
            // pctNeutral
            // 
            this.pctNeutral.Image = ((System.Drawing.Image)(resources.GetObject("pctNeutral.Image")));
            this.pctNeutral.Location = new System.Drawing.Point(12, 38);
            this.pctNeutral.Name = "pctNeutral";
            this.pctNeutral.Size = new System.Drawing.Size(163, 131);
            this.pctNeutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctNeutral.TabIndex = 10;
            this.pctNeutral.TabStop = false;
            // 
            // frmVCKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 335);
            this.Controls.Add(this.pctNeutral);
            this.Controls.Add(this.pctNoVirus);
            this.Controls.Add(this.pctVirus);
            this.Controls.Add(this.lblSikker);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lblVirus);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVCKS";
            this.Text = "VCKS Anti Virus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNeutral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblVirus;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblSikker;
        private System.Windows.Forms.PictureBox pctVirus;
        private System.Windows.Forms.PictureBox pctNoVirus;
        private System.Windows.Forms.PictureBox pctNeutral;
    }
}

