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
    public partial class frmKhachHang : Form
    {
        private Database db;
        private DataTable dtKhachHang;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void LoadDSKhachHang()
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@timKiem",
                    value = txtTimKiem.Text
                }
            };
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.Font = new Font("Arial", 9, FontStyle.Regular);

            dtKhachHang  = db.SelectData("LoadDSKhachHang", lst);

            dgvKhachHang.DataSource = dtKhachHang;

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSKhachHang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSKhachHang();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            frmInKhachHang fInKhachHang = new frmInKhachHang(dtKhachHang);
            fInKhachHang.ShowDialog();
        }
    }
}
