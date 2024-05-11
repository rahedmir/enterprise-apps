namespace domain_support
{
    partial class frm_domain_support_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_about));
            this.imgInformation = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthorMir = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // imgInformation
            // 
            this.imgInformation.Image = ((System.Drawing.Image)(resources.GetObject("imgInformation.Image")));
            this.imgInformation.Location = new System.Drawing.Point(260, 22);
            this.imgInformation.Name = "imgInformation";
            this.imgInformation.Size = new System.Drawing.Size(70, 68);
            this.imgInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInformation.TabIndex = 0;
            this.imgInformation.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(175, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Legacy Domain Support";
            // 
            // lblAuthorMir
            // 
            this.lblAuthorMir.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.lblAuthorMir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAuthorMir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorMir.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lblAuthorMir.Location = new System.Drawing.Point(83, 87);
            this.lblAuthorMir.Name = "lblAuthorMir";
            this.lblAuthorMir.Size = new System.Drawing.Size(123, 23);
            this.lblAuthorMir.TabIndex = 2;
            this.lblAuthorMir.TabStop = true;
            this.lblAuthorMir.Text = "Mir Rahed Uddin";
            this.lblAuthorMir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAuthorMir_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(22, 55);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(175, 23);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version : 3.0.0.0";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(22, 87);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(65, 23);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author :";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(22, 119);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(175, 23);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Copyright : © 2023";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(260, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 34);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frm_domain_support_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 204);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAuthorMir);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_about";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legacy Domain Support - About";
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgInformation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel lblAuthorMir;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnOK;
    }
}