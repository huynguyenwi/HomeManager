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
    public partial class frmNhaDangThue : Form
    {
        private Database db;
        private DataTable dtNhaDangThue;

        public frmNhaDangThue()
        {
            InitializeComponent();
        }

        private void LoadDSNhaDangThue()
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@timKiem",
                    value = txtTimKiem.Text
                }
            };
            dgvNhaDangThue.AutoGenerateColumns = false;
            dtNhaDangThue = db.SelectData("LoadDSNhaDangThue", lst);
            dgvNhaDangThue.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvNhaDangThue.DataSource = dtNhaDangThue;

        }

        private void frmNhaDangThue_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSNhaDangThue();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSNhaDangThue();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            frmInNhaDangThue fInNhaDangThue = new frmInNhaDangThue(dtNhaDangThue);
            fInNhaDangThue.ShowDialog();
        }
    }
}
