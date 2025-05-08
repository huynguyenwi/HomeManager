using QuanLyThueNha.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNha
{
    public partial class frmMain : Form
    {
        string taiKhoan, matKhau;
        public frmMain(string taiKhoan, string matKhau)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        #region gui
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void ptbExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Dispose();
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbState.Image = Properties.Resources.res;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbState.Image = Properties.Resources.maxi;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //hàm add form lên groupbox có tên là grbContent
        private void AddForm(Form form)
        {
            this.grbContent.Controls.Clear();//xóa các control hiện có trên groupbox
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            form.Dock = DockStyle.Fill;
            this.Text = form.Text;
            this.grbContent.Controls.Add(form);
            form.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome fWelcome = new frmWelcome();
            AddForm(fWelcome);
        }

        private void loaiNhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiNha fLoaiNha = new frmLoaiNha();
            AddForm(fLoaiNha);
        }

        private void nhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNha fNha = new frmNha();
            AddForm(fNha);
        }

        private void thuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThueNha fThueNha = new frmThueNha();
            AddForm(fThueNha);
        }

        private void traPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraNha fTraNha = new frmTraNha();    
            AddForm(fTraNha);
        }


        private void cauHinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCauHinh fCauHinh = new frmCauHinh();
            AddForm(fCauHinh);
        }

        private void nhaDangThueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaDangThue fNhaDangThue = new frmNhaDangThue();
            AddForm(fNhaDangThue);
        }

        private void nhaTrongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaChuaThue fNhaChuaThue = new frmNhaChuaThue();
            AddForm(fNhaChuaThue);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThu fDoanhThu = new frmDoanhThu();
            AddForm(fDoanhThu);
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang fKhachHang = new frmKhachHang();
            AddForm(fKhachHang);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDangNhap fDangNhap = new frmDangNhap();
            fDangNhap.Show();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fDoiMatKhau = new frmDoiMatKhau(taiKhoan, matKhau);
            AddForm(fDoiMatKhau);
        }
    }
}
