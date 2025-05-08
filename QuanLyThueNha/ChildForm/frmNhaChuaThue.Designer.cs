namespace QuanLyThueNha.ChildForm
{
    partial class frmNhaChuaThue
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
            this.dgvNhaDangThue = new System.Windows.Forms.DataGridView();
            this.IDNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXuatFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaDangThue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhaDangThue
            // 
            this.dgvNhaDangThue.AllowUserToAddRows = false;
            this.dgvNhaDangThue.AllowUserToDeleteRows = false;
            this.dgvNhaDangThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhaDangThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaDangThue.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhaDangThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaDangThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNha,
            this.TenNha,
            this.GiaNha,
            this.TrangThaiNha});
            this.dgvNhaDangThue.GridColor = System.Drawing.Color.Gray;
            this.dgvNhaDangThue.Location = new System.Drawing.Point(2, 173);
            this.dgvNhaDangThue.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhaDangThue.MultiSelect = false;
            this.dgvNhaDangThue.Name = "dgvNhaDangThue";
            this.dgvNhaDangThue.ReadOnly = true;
            this.dgvNhaDangThue.RowHeadersWidth = 51;
            this.dgvNhaDangThue.Size = new System.Drawing.Size(1167, 473);
            this.dgvNhaDangThue.TabIndex = 36;
            // 
            // IDNha
            // 
            this.IDNha.DataPropertyName = "IDNha";
            this.IDNha.HeaderText = "Mã nhà";
            this.IDNha.MinimumWidth = 6;
            this.IDNha.Name = "IDNha";
            this.IDNha.ReadOnly = true;
            // 
            // TenNha
            // 
            this.TenNha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNha.DataPropertyName = "TenNha";
            this.TenNha.HeaderText = "Loại nhà - Tên nhà";
            this.TenNha.MinimumWidth = 6;
            this.TenNha.Name = "TenNha";
            this.TenNha.ReadOnly = true;
            // 
            // GiaNha
            // 
            this.GiaNha.DataPropertyName = "GiaNha";
            this.GiaNha.HeaderText = "Giá nhà";
            this.GiaNha.MinimumWidth = 6;
            this.GiaNha.Name = "GiaNha";
            this.GiaNha.ReadOnly = true;
            // 
            // TrangThaiNha
            // 
            this.TrangThaiNha.DataPropertyName = "TrangThaiNha";
            this.TrangThaiNha.HeaderText = "Trạng thái";
            this.TrangThaiNha.MinimumWidth = 6;
            this.TrangThaiNha.Name = "TrangThaiNha";
            this.TrangThaiNha.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "THỐNG KÊ NHÀ TRỐNG";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(717, 99);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 34);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(464, 103);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 25);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXuatFile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXuatFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(834, 98);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(100, 34);
            this.btnXuatFile.TabIndex = 2;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // frmNhaChuaThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1172, 648);
            this.Controls.Add(this.dgvNhaDangThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "frmNhaChuaThue";
            this.Text = "frmNhaChuaThue";
            this.Load += new System.EventHandler(this.frmNhaChuaThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaDangThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaDangThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiNha;
        private System.Windows.Forms.Button btnXuatFile;
    }
}