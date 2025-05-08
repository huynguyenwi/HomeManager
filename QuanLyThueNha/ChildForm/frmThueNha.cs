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
    public partial class frmThueNha : Form
    {
        private Database db;
        public frmThueNha()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmThue().ShowDialog();
            LoadDSThueNha();
        }

        private void frmThueNha_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSThueNha();
        }

        private void LoadDSThueNha()
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@timKiem",
                    value = txtTimKiem.Text
                }
            };
            dgvThueNha.AutoGenerateColumns = false;
            dgvThueNha.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvThueNha.DataSource = db.SelectData("LoadDSHopDong", lst);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSThueNha();
        }

        private void dgvThueNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvThueNha.Columns["btnThanhToan"].Index)
                {
                    int IDHopDong = int.Parse(dgvThueNha.Rows[e.RowIndex].Cells["IDHopDong"].Value.ToString());
                    int CSD_Cu = int.Parse(dgvThueNha.Rows[e.RowIndex].Cells["CSD_Cu"].Value.ToString());
                    int CSN_Cu = int.Parse(dgvThueNha.Rows[e.RowIndex].Cells["CSN_Cu"].Value.ToString());

                    new frmChotDienNuoc(IDHopDong, CSD_Cu, CSN_Cu).ShowDialog();
                    LoadDSThueNha();
                }
            }
        }
    }
}
