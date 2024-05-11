namespace domain_support
{
    partial class frm_domain_support_sysInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_sysInfo));
            this.txtSystemInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSystemInfo
            // 
            this.txtSystemInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemInfo.Location = new System.Drawing.Point(12, 12);
            this.txtSystemInfo.Multiline = true;
            this.txtSystemInfo.Name = "txtSystemInfo";
            this.txtSystemInfo.ReadOnly = true;
            this.txtSystemInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSystemInfo.Size = new System.Drawing.Size(566, 327);
            this.txtSystemInfo.TabIndex = 0;
            this.txtSystemInfo.TabStop = false;
            this.txtSystemInfo.Text = "Loading...";
            // 
            // frm_domain_support_sysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 351);
            this.Controls.Add(this.txtSystemInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_sysInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legacy Domain Support - System Information";
            this.Load += new System.EventHandler(this.frm_domain_support_sysInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtSystemInfo;
    }
}