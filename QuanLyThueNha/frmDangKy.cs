using QuanLyThueNha.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNha
{
    public partial class frmDangKy : Form
    {
        Database db = new Database();

        #region dichuyenform
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion
        public frmDangKy()
        {
            InitializeComponent();
            lblDangKySai.Visible = false;
            lblDangKySai.Font = new Font("Arial", 8);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            lblDangKySai.Visible = false;

            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                lblDangKySai.Text = "Vui lòng điền tài khoản";
                lblDangKySai.Visible = true;
                txtTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                lblDangKySai.Text = "Vui lòng điền mật khẩu";
                lblDangKySai.Visible = true;
                txtMatKhau.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhauLai.Text))
            {
                lblDangKySai.Text = "Vui lòng điền mật khẩu nhập lại";
                lblDangKySai.Visible = true;
                txtMatKhauLai.Focus();
                return;
            }


            if (!txtMatKhau.Text.ToString().Equals(txtMatKhauLai.Text.ToString()))
            {
                lblDangKySai.Visible = true;
                lblDangKySai.Text = "Mật khẩu không khớp! Nhập lại mật khẩu";
                txtMatKhau.Focus();
                return;
            }


            // Kiểm tra tài khoản đã tồn tại chưa
            List<CustomParameter> lstCheck = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@TaiKhoan",
                    value = txtTaiKhoan.Text
                }
            };

            DataTable dtCheck = db.SelectData("KiemTraTaiKhoan", lstCheck);
            if (dtCheck.Rows.Count > 0 && (int)dtCheck.Rows[0]["SoLuong"] > 0)
            {
                lblDangKySai.Visible = true;
                lblDangKySai.Text = "Tài khoản đã tồn tại! Nhập tài khoản khác";
                txtTaiKhoan.Focus();
                return;
            }

            //Đăng ký tài khoản 
            List<CustomParameter> lst = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        key = "@TaiKhoan",
                        value = txtTaiKhoan.Text
                    },
                    new CustomParameter
                    {
                        key = "@MatKhau",
                        value = txtMatKhau.Text
                    }
                };

                int rs = db.ExeCute("DangKy", lst);
                if(rs == 1)
                {
                    lblDangKySai.Visible = true;
                    lblDangKySai.Text = "Đăng ký thành công";
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtMatKhauLai.Text = "";
                    txtTaiKhoan.Focus();
                }
            
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap fDangNhap = new frmDangNhap();
            fDangNhap.Show();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy_Click(sender, e);
                e.SuppressKeyPress = true;// Ngăn tiếng "beep" khi nhấn Enter
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy_Click(sender, e);
                e.SuppressKeyPress = true;// Ngăn tiếng "beep" khi nhấn Enter
            }
        }

        private void txtMatKhauLai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy_Click(sender, e);
                e.SuppressKeyPress = true;// Ngăn tiếng "beep" khi nhấn Enter
            }
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }
    }
}
