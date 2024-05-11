namespace domain_support
{
    partial class frm_domain_support_domain_removal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_domain_removal));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ImgDomainRemove = new System.Windows.Forms.PictureBox();
            this.txtAssetCode = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.ImgPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDomainRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(13, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Password";
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(13, 128);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(80, 23);
            this.lbID.TabIndex = 32;
            this.lbID.Text = "UID";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(114, 157);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(228, 26);
            this.txtPassword.TabIndex = 31;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(114, 125);
            this.txtID.MaxLength = 100;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(261, 26);
            this.txtID.TabIndex = 30;
            // 
            // ImgDomainRemove
            // 
            this.ImgDomainRemove.Image = ((System.Drawing.Image)(resources.GetObject("ImgDomainRemove.Image")));
            this.ImgDomainRemove.Location = new System.Drawing.Point(13, 16);
            this.ImgDomainRemove.Name = "ImgDomainRemove";
            this.ImgDomainRemove.Size = new System.Drawing.Size(73, 81);
            this.ImgDomainRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgDomainRemove.TabIndex = 29;
            this.ImgDomainRemove.TabStop = false;
            // 
            // txtAssetCode
            // 
            this.txtAssetCode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetCode.Location = new System.Drawing.Point(114, 16);
            this.txtAssetCode.MaxLength = 1000;
            this.txtAssetCode.Multiline = true;
            this.txtAssetCode.Name = "txtAssetCode";
            this.txtAssetCode.ReadOnly = true;
            this.txtAssetCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAssetCode.Size = new System.Drawing.Size(261, 50);
            this.txtAssetCode.TabIndex = 28;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(223, 198);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 34);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Domain Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSeparator.Location = new System.Drawing.Point(112, 84);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(269, 18);
            this.lblSeparator.TabIndex = 26;
            this.lblSeparator.Text = "__________________________________________________________________________";
            this.lblSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgPassword
            // 
            this.ImgPassword.Image = ((System.Drawing.Image)(resources.GetObject("ImgPassword.Image")));
            this.ImgPassword.Location = new System.Drawing.Point(348, 157);
            this.ImgPassword.Name = "ImgPassword";
            this.ImgPassword.Size = new System.Drawing.Size(27, 26);
            this.ImgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPassword.TabIndex = 34;
            this.ImgPassword.TabStop = false;
            this.ImgPassword.Click += new System.EventHandler(this.ImgPassword_Click);
            // 
            // frm_domain_support_domain_removal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 249);
            this.Controls.Add(this.ImgPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ImgDomainRemove);
            this.Controls.Add(this.txtAssetCode);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSeparator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_domain_removal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legacy Domain Support - Domain Remove";
            this.Load += new System.EventHandler(this.frm_domain_support_domain_removal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgDomainRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox ImgDomainRemove;
        private System.Windows.Forms.TextBox txtAssetCode;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.PictureBox ImgPassword;
    }
}