namespace QuanLyThueNha.ChildForm
{
    partial class frmInHoaDonThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHoaDonThanhToan));
            this.rpvỊnHoaDonThanhToan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvỊnHoaDonThanhToan
            // 
            this.rpvỊnHoaDonThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvỊnHoaDonThanhToan.Location = new System.Drawing.Point(2, 2);
            this.rpvỊnHoaDonThanhToan.Name = "rpvỊnHoaDonThanhToan";
            this.rpvỊnHoaDonThanhToan.ServerReport.BearerToken = null;
            this.rpvỊnHoaDonThanhToan.Size = new System.Drawing.Size(1117, 751);
            this.rpvỊnHoaDonThanhToan.TabIndex = 1;
            // 
            // frmInHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 755);
            this.Controls.Add(this.rpvỊnHoaDonThanhToan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInHoaDonThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInHoaDonThanhToan";
            this.Load += new System.EventHandler(this.frmInHoaDonThanhToan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvỊnHoaDonThanhToan;
    }
}