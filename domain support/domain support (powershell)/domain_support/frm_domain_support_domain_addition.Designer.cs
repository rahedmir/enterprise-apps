namespace domain_support
{
    partial class frm_domain_support_domain_addition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_domain_addition));
            this.comboDomainList = new System.Windows.Forms.ComboBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.txtAssetCode = new System.Windows.Forms.TextBox();
            this.ImgDomainJoin = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ImgPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDomainJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDomainList
            // 
            this.comboDomainList.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDomainList.FormattingEnabled = true;
            this.comboDomainList.Items.AddRange(new object[] {
            "ABC.com",
            "EFG.corp",
            "PQR.corp",
            "XYZ.com"});
            this.comboDomainList.Location = new System.Drawing.Point(113, 21);
            this.comboDomainList.Name = "comboDomainList";
            this.comboDomainList.Size = new System.Drawing.Size(261, 24);
            this.comboDomainList.TabIndex = 6;
            this.comboDomainList.TabStop = false;
            this.comboDomainList.Text = "ABC.com";
            this.comboDomainList.SelectedIndexChanged += new System.EventHandler(this.comboDomainList_SelectedIndexChanged);
            // 
            // lblSeparator
            // 
            this.lblSeparator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSeparator.Location = new System.Drawing.Point(111, 80);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(269, 18);
            this.lblSeparator.TabIndex = 17;
            this.lblSeparator.Text = "__________________________________________________________________________";
            this.lblSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(239, 194);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(135, 34);
            this.btnJoin.TabIndex = 18;
            this.btnJoin.Text = "Domain Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // txtAssetCode
            // 
            this.txtAssetCode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetCode.Location = new System.Drawing.Point(113, 51);
            this.txtAssetCode.MaxLength = 100;
            this.txtAssetCode.Name = "txtAssetCode";
            this.txtAssetCode.ReadOnly = true;
            this.txtAssetCode.Size = new System.Drawing.Size(261, 26);
            this.txtAssetCode.TabIndex = 19;
            // 
            // ImgDomainJoin
            // 
            this.ImgDomainJoin.Image = ((System.Drawing.Image)(resources.GetObject("ImgDomainJoin.Image")));
            this.ImgDomainJoin.Location = new System.Drawing.Point(12, 12);
            this.ImgDomainJoin.Name = "ImgDomainJoin";
            this.ImgDomainJoin.Size = new System.Drawing.Size(73, 81);
            this.ImgDomainJoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgDomainJoin.TabIndex = 20;
            this.ImgDomainJoin.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(113, 121);
            this.txtID.MaxLength = 100;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(261, 26);
            this.txtID.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(113, 153);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(228, 26);
            this.txtPassword.TabIndex = 22;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(12, 124);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(80, 23);
            this.lbID.TabIndex = 23;
            this.lbID.Text = "UID";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 156);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password";
            // 
            // ImgPassword
            // 
            this.ImgPassword.Image = ((System.Drawing.Image)(resources.GetObject("ImgPassword.Image")));
            this.ImgPassword.Location = new System.Drawing.Point(347, 153);
            this.ImgPassword.Name = "ImgPassword";
            this.ImgPassword.Size = new System.Drawing.Size(27, 26);
            this.ImgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPassword.TabIndex = 27;
            this.ImgPassword.TabStop = false;
            this.ImgPassword.Click += new System.EventHandler(this.ImgPassword_Click);
            // 
            // frm_domain_support_domain_addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 249);
            this.Controls.Add(this.ImgPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ImgDomainJoin);
            this.Controls.Add(this.txtAssetCode);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.comboDomainList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_domain_addition";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legacy Domain Support - Domain Join";
            this.Load += new System.EventHandler(this.frm_domain_support_domain_addition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgDomainJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboDomainList;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TextBox txtAssetCode;
        private System.Windows.Forms.PictureBox ImgDomainJoin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox ImgPassword;
    }
}