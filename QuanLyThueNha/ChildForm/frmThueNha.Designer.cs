namespace QuanLyThueNha.ChildForm
{
    partial class frmThueNha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThueNha = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienVeSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienMang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSD_Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSN_Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new QuanLyThueNha.QuanLyThueNhaDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueNha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(806, 104);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 34);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemMoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemMoi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(913, 104);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 34);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thuê mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(559, 107);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 25);
            this.txtTimKiem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tìm kiếm";
            // 
            // dgvThueNha
            // 
            this.dgvThueNha.AllowUserToAddRows = false;
            this.dgvThueNha.AllowUserToDeleteRows = false;
            this.dgvThueNha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThueNha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThueNha.BackgroundColor = System.Drawing.Color.White;
            this.dgvThueNha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThueNha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnThanhToan,
            this.HoTenKH,
            this.TenNha,
            this.GiaNha,
            this.DatCoc,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TienVeSinh,
            this.TienMang,
            this.DonGiaDien,
            this.CSD_Cu,
            this.DonGiaNuoc,
            this.CSN_Cu,
            this.no,
            this.IDHopDong});
            this.dgvThueNha.GridColor = System.Drawing.Color.Gray;
            this.dgvThueNha.Location = new System.Drawing.Point(2, 157);
            this.dgvThueNha.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThueNha.MultiSelect = false;
            this.dgvThueNha.Name = "dgvThueNha";
            this.dgvThueNha.ReadOnly = true;
            this.dgvThueNha.RowHeadersWidth = 51;
            this.dgvThueNha.Size = new System.Drawing.Size(1414, 361);
            this.dgvThueNha.TabIndex = 17;
            this.dgvThueNha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThueNha_CellClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.HeaderText = "";
            this.btnThanhToan.MinimumWidth = 6;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ReadOnly = true;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseColumnTextForButtonValue = true;
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Tên khách hàng";
            this.HoTenKH.MinimumWidth = 6;
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.ReadOnly = true;
            // 
            // TenNha
            // 
            this.TenNha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNha.DataPropertyName = "TenNha";
            this.TenNha.FillWeight = 120F;
            this.TenNha.HeaderText = "Loại nhà - Tên nhà";
            this.TenNha.MinimumWidth = 6;
            this.TenNha.Name = "TenNha";
            this.TenNha.ReadOnly = true;
            // 
            // GiaNha
            // 
            this.GiaNha.DataPropertyName = "GiaNha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.GiaNha.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaNha.HeaderText = "Giá nhà";
            this.GiaNha.MinimumWidth = 6;
            this.GiaNha.Name = "GiaNha";
            this.GiaNha.ReadOnly = true;
            // 
            // DatCoc
            // 
            this.DatCoc.DataPropertyName = "DatCoc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DatCoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatCoc.FillWeight = 80F;
            this.DatCoc.HeaderText = "Đặt cọc";
            this.DatCoc.MinimumWidth = 6;
            this.DatCoc.Name = "DatCoc";
            this.DatCoc.ReadOnly = true;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày thuê";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày trả";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // TienVeSinh
            // 
            this.TienVeSinh.DataPropertyName = "TienVeSinh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TienVeSinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.TienVeSinh.HeaderText = "Tiền vệ sinh";
            this.TienVeSinh.MinimumWidth = 6;
            this.TienVeSinh.Name = "TienVeSinh";
            this.TienVeSinh.ReadOnly = true;
            // 
            // TienMang
            // 
            this.TienMang.DataPropertyName = "TienMang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TienMang.DefaultCellStyle = dataGridViewCellStyle4;
            this.TienMang.HeaderText = "Tiền mạng";
            this.TienMang.MinimumWidth = 6;
            this.TienMang.Name = "TienMang";
            this.TienMang.ReadOnly = true;
            // 
            // DonGiaDien
            // 
            this.DonGiaDien.DataPropertyName = "DonGiaDien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DonGiaDien.DefaultCellStyle = dataGridViewCellStyle5;
            this.DonGiaDien.HeaderText = "Đơn giá điện";
            this.DonGiaDien.MinimumWidth = 6;
            this.DonGiaDien.Name = "DonGiaDien";
            this.DonGiaDien.ReadOnly = true;
            // 
            // CSD_Cu
            // 
            this.CSD_Cu.DataPropertyName = "CSD_Cu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CSD_Cu.DefaultCellStyle = dataGridViewCellStyle6;
            this.CSD_Cu.HeaderText = "Số điện cũ";
            this.CSD_Cu.MinimumWidth = 6;
            this.CSD_Cu.Name = "CSD_Cu";
            this.CSD_Cu.ReadOnly = true;
            // 
            // DonGiaNuoc
            // 
            this.DonGiaNuoc.DataPropertyName = "DonGiaNuoc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DonGiaNuoc.DefaultCellStyle = dataGridViewCellStyle7;
            this.DonGiaNuoc.HeaderText = "Đơn giá nước";
            this.DonGiaNuoc.MinimumWidth = 6;
            this.DonGiaNuoc.Name = "DonGiaNuoc";
            this.DonGiaNuoc.ReadOnly = true;
            // 
            // CSN_Cu
            // 
            this.CSN_Cu.DataPropertyName = "CSN_Cu";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CSN_Cu.DefaultCellStyle = dataGridViewCellStyle8;
            this.CSN_Cu.HeaderText = "Số nước cũ";
            this.CSN_Cu.MinimumWidth = 6;
            this.CSN_Cu.Name = "CSN_Cu";
            this.CSN_Cu.ReadOnly = true;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.no.DefaultCellStyle = dataGridViewCellStyle9;
            this.no.HeaderText = "Dư nợ";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // IDHopDong
            // 
            this.IDHopDong.DataPropertyName = "IDHopDong";
            this.IDHopDong.HeaderText = "IDHopDong";
            this.IDHopDong.MinimumWidth = 6;
            this.IDHopDong.Name = "IDHopDong";
            this.IDHopDong.ReadOnly = true;
            this.IDHopDong.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ KHÁCH THUÊ NHÀ";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyThueNha.QuanLyThueNhaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmThueNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1417, 521);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThueNha);
            this.Controls.Add(this.label1);
            this.Name = "frmThueNha";
            this.Text = "frmThueNha";
            this.Load += new System.EventHandler(this.frmThueNha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueNha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThueNha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienVeSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienMang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSD_Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSN_Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHopDong;
        private QuanLyThueNhaDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}