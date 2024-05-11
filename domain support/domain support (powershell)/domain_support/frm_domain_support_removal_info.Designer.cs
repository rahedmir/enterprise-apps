namespace domain_support
{
    partial class frm_domain_support_removal_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_removal_info));
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblFirstInfo = new System.Windows.Forms.Label();
            this.lblSecondInfo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbl_InfoHeading = new System.Windows.Forms.Label();
            this.imgInformation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Info
            // 
            this.lbl_Info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(31, 65);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(175, 23);
            this.lbl_Info.TabIndex = 19;
            this.lbl_Info.Text = "note the followings -";
            // 
            // lblSeparator
            // 
            this.lblSeparator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSeparator.Location = new System.Drawing.Point(25, 82);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(252, 18);
            this.lblSeparator.TabIndex = 25;
            this.lblSeparator.Text = "______________________________________________";
            this.lblSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstInfo
            // 
            this.lblFirstInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstInfo.Location = new System.Drawing.Point(32, 113);
            this.lblFirstInfo.Name = "lblFirstInfo";
            this.lblFirstInfo.Size = new System.Drawing.Size(215, 39);
            this.lblFirstInfo.TabIndex = 24;
            this.lblFirstInfo.Text = "1. If LAN is connected, Domain UID, Password is required.";
            // 
            // lblSecondInfo
            // 
            this.lblSecondInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondInfo.Location = new System.Drawing.Point(31, 161);
            this.lblSecondInfo.Name = "lblSecondInfo";
            this.lblSecondInfo.Size = new System.Drawing.Size(246, 40);
            this.lblSecondInfo.TabIndex = 21;
            this.lblSecondInfo.Text = "2. If LAN is not connected, no credentials are required.";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(299, 202);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 34);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbl_InfoHeading
            // 
            this.lbl_InfoHeading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InfoHeading.Location = new System.Drawing.Point(31, 32);
            this.lbl_InfoHeading.Name = "lbl_InfoHeading";
            this.lbl_InfoHeading.Size = new System.Drawing.Size(175, 23);
            this.lbl_InfoHeading.TabIndex = 18;
            this.lbl_InfoHeading.Text = "Before You Proceed";
            // 
            // imgInformation
            // 
            this.imgInformation.Image = ((System.Drawing.Image)(resources.GetObject("imgInformation.Image")));
            this.imgInformation.Location = new System.Drawing.Point(299, 32);
            this.imgInformation.Name = "imgInformation";
            this.imgInformation.Size = new System.Drawing.Size(70, 68);
            this.imgInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInformation.TabIndex = 17;
            this.imgInformation.TabStop = false;
            // 
            // frm_domain_support_removal_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 268);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblFirstInfo);
            this.Controls.Add(this.lblSecondInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbl_InfoHeading);
            this.Controls.Add(this.imgInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_removal_info";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legacy Domain Support - Remove Info";
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblFirstInfo;
        private System.Windows.Forms.Label lblSecondInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbl_InfoHeading;
        private System.Windows.Forms.PictureBox imgInformation;
    }
}