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
    public partial class frmDoiMatKhau : Form
    {
        Database db;
        string taiKhoan, matKhau;
        public frmDoiMatKhau(string taiKhoan, string matKhau)
        {
            InitializeComponent();
            this.db = new Database();
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            lblDoiMatKhau.Visible = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            lblDoiMatKhau.Visible = false;

            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                lblDoiMatKhau.Text = "Vui lòng điền mật khẩu cũ ";
                lblDoiMatKhau.Visible = true;
                txtMatKhauCu.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                lblDoiMatKhau.Text = "Vui lòng điền mật khẩu mới";
                lblDoiMatKhau.Visible = true;
                txtMatKhauMoi.Focus();
                return;
            }
            if (!matKhau.Equals(txtMatKhauCu.Text.ToString())) {   
                lblDoiMatKhau.Text = "Mật khẩu cũ không đúng ";
                lblDoiMatKhau.Visible = true;
                txtMatKhauCu.Focus();
                return;
            }
            if (txtMatKhauCu.Text.Equals(txtMatKhauMoi.Text))
            {
                lblDoiMatKhau.Text = "Mật khẩu mới phải khác mật khẩu cũ.";
                lblDoiMatKhau.Visible = true;
                txtMatKhauMoi.Focus();
                return;
            }
            else
            {
                List<CustomParameter> lst = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        key = "@TaiKhoan",
                        value = taiKhoan
                    },
                    new CustomParameter
                    {
                        key = "@MatKhau",
                        value = txtMatKhauMoi.Text
                    }
                };
                int rs = db.ExeCute("DoiMatKhau", lst);
                if (rs == 1)
                {
                    lblDoiMatKhau.Visible = true;
                    lblDoiMatKhau.Text = "Đổi mật khẩu thành công";
                    matKhau = txtMatKhauMoi.Text; // Cập nhật mật khẩu mới
                    txtMatKhauCu.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtMatKhauCu.Focus();
                }
            }
        }

        private void txtMatKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXacNhan_Click(sender, e);
                e.SuppressKeyPress = true;// Ngăn tiếng "beep" khi nhấn Enter
            }
        }

        private void txtMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXacNhan_Click(sender, e);
                e.SuppressKeyPress = true;// Ngăn tiếng "beep" khi nhấn Enter
            }
        }


        
    }
}
