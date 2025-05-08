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
    public partial class frmNhaChuaThue : Form
    {
        private Database db;
        private DataTable dtNhaChuaThue;
        public frmNhaChuaThue()
        {
            InitializeComponent();
        }

        private void LoadDSNhaChuaThue()
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@timKiem",
                    value = txtTimKiem.Text
                }
            };
            dgvNhaDangThue.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvNhaDangThue.AutoGenerateColumns = false;
            dtNhaChuaThue = db.SelectData("LoadDSNhaChuaThue", lst);
            dgvNhaDangThue.DataSource = dtNhaChuaThue;

        }

        private void frmNhaChuaThue_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSNhaChuaThue();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSNhaChuaThue();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            frmInNhaChuaThue fInNhaChuaThue = new frmInNhaChuaThue(dtNhaChuaThue);
            fInNhaChuaThue.ShowDialog();
        }
    }
}
