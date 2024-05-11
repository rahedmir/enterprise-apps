namespace domain_support
{
    partial class frm_domain_support_serial_num
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domain_support_serial_num));
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNum.Location = new System.Drawing.Point(12, 12);
            this.txtSerialNum.Multiline = true;
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.ReadOnly = true;
            this.txtSerialNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerialNum.Size = new System.Drawing.Size(302, 56);
            this.txtSerialNum.TabIndex = 1;
            this.txtSerialNum.TabStop = false;
            this.txtSerialNum.Text = "Loading...";
            // 
            // frm_domain_support_serial_num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 82);
            this.Controls.Add(this.txtSerialNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_domain_support_serial_num";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legacy Domain Support - Asset Serial Number";
            this.Load += new System.EventHandler(this.frm_domain_support_serial_num_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtSerialNum;
    }
}