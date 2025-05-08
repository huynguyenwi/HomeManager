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
    public partial class frmDangNhap : Form
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
        public frmDangNhap()
        {
            InitializeComponent();
            lblDangNhapSai.Visible = false;
            lblDangNhapSai.Font = new Font("Arial", 8);
        }
        

        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            lblDangNhapSai.Visible = false;

            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) )
            {
                lblDangNhapSai.Text = "Vui lòng điền tài khoản ";
                lblDangNhapSai.Visible = true;
                txtTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                lblDangNhapSai.Text = "Vui lòng điền mật khẩu ";
                lblDangNhapSai.Visible = true;
                txtMatKhau.Focus();     
                return;
            }

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
            DataTable rs = db.SelectData("DangNhap", lst);
            if (rs.Rows.Count <= 0)
            {
                lblDangNhapSai.Visible = true;
                lblDangNhapSai.Text = "Tên đăng nhập hoặc mật khẩu sai";
                txtTaiKhoan.Focus();
                return;
            }
            else
            {
                frmMain fMain = new frmMain(txtTaiKhoan.Text, txtMatKhau.Text);
                fMain.Show();
                this.Hide();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy fDangKy = new frmDangKy();
            fDangKy.Show();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                e.SuppressKeyPress = true;// Ngăn tiếng "beep" khi nhấn Enter
            }
        }

       
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                e.SuppressKeyPress = true;// Ngăn tiếng "beep" khi nhấn Enter
            }
        }
    }
}
