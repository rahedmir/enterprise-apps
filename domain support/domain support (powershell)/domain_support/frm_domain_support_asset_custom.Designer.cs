namespace domain_support
{
    partial class frm_domain_support_asset_custom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_asset_custom));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.ImgCustom = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtCustom);
            this.groupBox.Location = new System.Drawing.Point(77, 14);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(226, 53);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            // 
            // txtCustom
            // 
            this.txtCustom.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustom.Location = new System.Drawing.Point(6, 16);
            this.txtCustom.MaxLength = 14;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(211, 26);
            this.txtCustom.TabIndex = 5;
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(112, 90);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(106, 32);
            this.btnRename.TabIndex = 12;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // ImgCustom
            // 
            this.ImgCustom.Image = ((System.Drawing.Image)(resources.GetObject("ImgCustom.Image")));
            this.ImgCustom.Location = new System.Drawing.Point(14, 14);
            this.ImgCustom.Name = "ImgCustom";
            this.ImgCustom.Size = new System.Drawing.Size(57, 53);
            this.ImgCustom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCustom.TabIndex = 11;
            this.ImgCustom.TabStop = false;
            // 
            // frm_domain_support_asset_custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 137);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.ImgCustom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_asset_custom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legacy Domain Support - Asset Rename...";
            this.Load += new System.EventHandler(this.frm_domain_support_asset_custom_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCustom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.PictureBox ImgCustom;
    }
}