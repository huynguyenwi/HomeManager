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
    public partial class frmTraNha : Form
    {
        private Database db;

        public frmTraNha()
        {
            InitializeComponent();
        }

        private void LoadDSTraNha()
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@timKiem",
                    value = txtTimKiem.Text
                }
            };
            dgvTraNha.AutoGenerateColumns = false;
            dgvTraNha.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvTraNha.DataSource = db.SelectData("LoadDSHopDongKetThuc", lst);

        }

        private void frmTraNha_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSTraNha();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSTraNha();
        }
    }
}
