namespace QuanLyThueNha.ChildForm
{
    partial class frmInNhaChuaThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInNhaChuaThue));
            this.rpvNhaChuaThue = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvNhaChuaThue
            // 
            this.rpvNhaChuaThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvNhaChuaThue.Location = new System.Drawing.Point(0, 0);
            this.rpvNhaChuaThue.Name = "rpvNhaChuaThue";
            this.rpvNhaChuaThue.ServerReport.BearerToken = null;
            this.rpvNhaChuaThue.Size = new System.Drawing.Size(1117, 751);
            this.rpvNhaChuaThue.TabIndex = 0;
            // 
            // frmInNhaChuaThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 751);
            this.Controls.Add(this.rpvNhaChuaThue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInNhaChuaThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "In nhà chưa thuê";
            this.Load += new System.EventHandler(this.frmInNhaChuaThue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNhaChuaThue;
    }
}