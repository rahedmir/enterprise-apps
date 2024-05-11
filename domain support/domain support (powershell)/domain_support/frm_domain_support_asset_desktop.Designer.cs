namespace domain_support
{
    partial class frm_domain_support_asset_desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_asset_desktop));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblBHK = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblIBI = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.ImgDesktop = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtYear);
            this.groupBox.Controls.Add(this.txtNum);
            this.groupBox.Controls.Add(this.lblBHK);
            this.groupBox.Controls.Add(this.lblYear);
            this.groupBox.Controls.Add(this.lblIBI);
            this.groupBox.Location = new System.Drawing.Point(77, 14);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(226, 53);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(145, 16);
            this.txtNum.MaxLength = 6;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(72, 26);
            this.txtNum.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(62, 16);
            this.txtYear.MaxLength = 2;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(34, 26);
            this.txtYear.TabIndex = 2;
            // 
            // lblBHK
            // 
            this.lblBHK.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBHK.Location = new System.Drawing.Point(90, 16);
            this.lblBHK.Name = "lblBHK";
            this.lblBHK.Size = new System.Drawing.Size(64, 21);
            this.lblBHK.TabIndex = 4;
            this.lblBHK.Tag = "";
            this.lblBHK.Text = " BHK";
            this.lblBHK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(31, 16);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(34, 21);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "20";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIBI
            // 
            this.lblIBI.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIBI.Location = new System.Drawing.Point(6, 16);
            this.lblIBI.Name = "lblIBI";
            this.lblIBI.Size = new System.Drawing.Size(33, 21);
            this.lblIBI.TabIndex = 0;
            this.lblIBI.Text = "IBI";
            this.lblIBI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(112, 90);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(106, 32);
            this.btnRename.TabIndex = 9;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // ImgDesktop
            // 
            this.ImgDesktop.Image = ((System.Drawing.Image)(resources.GetObject("ImgDesktop.Image")));
            this.ImgDesktop.Location = new System.Drawing.Point(14, 14);
            this.ImgDesktop.Name = "ImgDesktop";
            this.ImgDesktop.Size = new System.Drawing.Size(57, 53);
            this.ImgDesktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgDesktop.TabIndex = 8;
            this.ImgDesktop.TabStop = false;
            // 
            // frm_domain_support_asset_desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 137);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.ImgDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_asset_desktop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legacy Domain Support - Asset Rename...";
            this.Load += new System.EventHandler(this.frm_domain_support_asset_desktop_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblBHK;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblIBI;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.PictureBox ImgDesktop;
    }
}