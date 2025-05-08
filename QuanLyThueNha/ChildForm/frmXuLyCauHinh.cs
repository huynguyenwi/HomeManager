using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNha.ChildForm
{
    public partial class frmXuLyCauHinh : Form
    {
        private string idCauHinh;
        private Database db;
        public frmXuLyCauHinh(string idCauHinh)
        {
            this.idCauHinh = idCauHinh;

            InitializeComponent();
        }

        private void frmXuLyCauHinh_Load(object sender, EventArgs e)
        {
            db = new Database();

            if (string.IsNullOrEmpty(idCauHinh))//nếu idCauHinh đc truyền qua là null = trường hợp thêm mới
            {
                lblTitle.Text = "Thêm cấu hình mới";
            }
            else//nếu idCauHinh khác null <=> trường hợp cập nhật thông tin cấu hình
            {
                lblTitle.Text = "Cập nhật thông tin cấu hình";

                //vì cấu hình được xác định qua id nên chúng ta cần truyền tham số là giá trị của id cấu hình vào
                List<CustomParameter> lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idCauHinh",
                        value = idCauHinh
                    }
                };
                var cauhinh = db.SelectData("SelectCauHinh", lstPara).Rows[0];// sử dụng hàm selectdata trong class datatabase để lấy dữ liệu cấu hình

                //kết quả trả về là 1 datatable chỉ gồm 1 hàng chính là hàng có chỉ số hàng bằng 0

                //set các dữ liệu lấy đc cho các component trên form frmXyLyCauHinh

                txtTenKhuQuanLy.Text = cauhinh["TenKhuQuanLy"].ToString();//set giá trị tên nhà cho textbox txtTenKhuQuanLy
                txtTenQuanLy.Text = cauhinh["TenQuanLy"].ToString();//set giá trị tên nhà cho textbox txtTTenQuanLy
                txtDiaChiKhuQuanLy.Text = cauhinh["DiaChiKhuQuanLy"].ToString();//set giá trị tên nhà cho textbox txtDiaChiKhuQuanLy
                txtSoDienThoai.Text = cauhinh["SoDienThoai"].ToString();//set giá trị tên nhà cho textbox txtSoDienThoai
                txtDonGiaDien.Text = cauhinh["DonGiaDien"].ToString();//set giá trị tên nhà cho textbox txtDonGiaDien
                txtDonGiaNuoc.Text = cauhinh["DonGiaNuoc"].ToString();//set giá trị tên nhà cho textbox txtDonGiaNuoc
                txtTienVeSinh.Text = cauhinh["TienVeSinh"].ToString();//set giá trị tên nhà cho textbox txtTienVeSinh
                txtTienMang.Text = cauhinh["TienMang"].ToString();//set giá trị tên nhà cho textbox txtTienMang
                

            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenKhuQuanLy = txtTenKhuQuanLy.Text.Trim();
            string tenQuanLy = txtTenQuanLy.Text.Trim();
            string diaChiKhuQuanLy = txtDiaChiKhuQuanLy.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string donGiaDien = txtDonGiaDien.Text.Trim();
            string donGiaNuoc = txtDonGiaNuoc.Text.Trim();
            string tienVeSinh = txtTienVeSinh.Text.Trim();
            string tienMang = txtTienMang.Text.Trim();
            

            if (string.IsNullOrEmpty(tenKhuQuanLy))
            {
                MessageBox.Show("Vui lòng nhập tên khu quản lý", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhuQuanLy.Select();
                return;
            }

            if (string.IsNullOrEmpty(tenQuanLy))
            {
                MessageBox.Show("Vui lòng nhập tên quản lý", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQuanLy.Select();
                return;
            }

            if (string.IsNullOrEmpty(diaChiKhuQuanLy))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khu quản lý", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiKhuQuanLy.Select();
                return;
            }

            if (string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Select();
                return;
            }

            if (string.IsNullOrEmpty(donGiaDien))
            {
                MessageBox.Show("Vui lòng nhập đơn giá điện", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaDien.Select();
                return;
            }

            if (string.IsNullOrEmpty(donGiaNuoc))
            {
                MessageBox.Show("Vui lòng nhập đơn giá nước", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaNuoc.Select();
                return;
            }

            if (string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập tiền vệ sinh", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienVeSinh.Select();
                return;
            }

            if (string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập tiền mạng", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienMang.Select();
                return;
            }


            if (string.IsNullOrEmpty(idCauHinh))//trường hợp thêm mới cầu hình không có idCauHinh <=> null
            {
                List<CustomParameter> lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@tenKhuQuanLy",
                        value = tenKhuQuanLy
                    },
                    new CustomParameter()
                    {
                        key = "@tenQuanLy",
                        value = tenQuanLy
                    },
                    new CustomParameter()
                    {
                        key = "@diaChiKhuQuanLy",
                        value = diaChiKhuQuanLy
                    },
                    new CustomParameter()
                    {
                        key = "@soDienThoai",
                        value = soDienThoai
                    },
                     new CustomParameter()
                    {
                        key = "@donGiaDien",
                        value = donGiaDien
                    },
                      new CustomParameter()
                    {
                        key = "@donGiaNuoc",
                        value = donGiaNuoc
                    },
                      new CustomParameter()
                    {
                        key = "@tienVeSinh",
                        value = tienVeSinh
                    },
                        new CustomParameter()
                    {
                        key = "@tienMang",
                        value = tienMang
                    },

                };
                int rs = db.ExeCute("ThemMoiCauHinh", lstPra);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            else//trường hợp cập nhật cấu hình đã tồn tại <=> idCauHinh có giá trị # null
            {
                List<CustomParameter> lstPara = new List<CustomParameter>()
               {
                     new CustomParameter()
                    {
                        key = "@idCauHinh",
                        value = idCauHinh
                    },
                   new CustomParameter()
                    {
                        key = "@tenKhuQuanLy",
                        value = tenKhuQuanLy
                    },
                    new CustomParameter()
                    {
                        key = "@tenQuanLy",
                        value = tenQuanLy
                    },
                    new CustomParameter()
                    {
                        key = "@diaChiKhuQuanLy",
                        value = diaChiKhuQuanLy
                    },
                    new CustomParameter()
                    {
                        key = "@soDienThoai",
                        value = soDienThoai
                    },
                     new CustomParameter()
                     {
                         key = "@donGiaDien",
                         value = donGiaDien
                      },
                      new CustomParameter()
                      {
                         key = "@donGiaNuoc",
                         value = donGiaNuoc
                       },
                       new CustomParameter()
                       {
                          key = "@tienVeSinh",
                          value = tienVeSinh
                       },
                       new CustomParameter()
                       {
                          key = "@tienMang",
                          value = tienMang
                       }
               };
                int kq = db.ExeCute("UpdateCauHinh", lstPara);
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin cấu hình thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo thành công
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin cấu hình không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo không thành công
                }
            }
        }

        #region keypress
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDonGiaDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDonGiaNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void txtTienVeSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTienMang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

    }
}

