namespace QuanLyThueNha.ChildForm
{
    partial class frmInKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInKhachHang));
            this.rpvKhachHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvKhachHang
            // 
            this.rpvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.rpvKhachHang.Name = "rpvKhachHang";
            this.rpvKhachHang.ServerReport.BearerToken = null;
            this.rpvKhachHang.Size = new System.Drawing.Size(1836, 751);
            this.rpvKhachHang.TabIndex = 0;
            // 
            // frmInKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 751);
            this.Controls.Add(this.rpvKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "In khách hàng";
            this.Load += new System.EventHandler(this.frmInKhachHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvKhachHang;
    }
}