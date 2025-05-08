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
    public partial class frmChotDienNuoc : Form
    {
        Database db = new Database();

        private int idHopDong, CSD_Cu, CSN_Cu;

        public frmChotDienNuoc(int idHopDong, int CSD_Cu, int CSN_Cu)
        {
            InitializeComponent();
            this.idHopDong = idHopDong;
            this.CSD_Cu = CSD_Cu;
            this.CSN_Cu = CSN_Cu;
        }

        private void frmChotDienNuoc_Load(object sender, EventArgs e)
        {
            txtCSD_Cu.Text = string.Format("{0:N0}", CSD_Cu);
            txtCSN_Cu.Text = string.Format("{0:N0}", CSN_Cu);
        }

        private void txtCSD_Moi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCSN_Moi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int CSD_Moi = txtCSD_Moi.Text.Trim().Length == 0 ? 0 : int.Parse(txtCSD_Moi.Text);
            int CSN_Moi = txtCSN_Moi.Text.Trim().Length == 0 ? 0 : int.Parse(txtCSN_Moi.Text);

            //ràng buộc dữ liệu chỉ số điện và nước
            if (CSD_Moi < CSD_Cu)
            {
                MessageBox.Show("Chỉ số điện mới không thể bé hơn chỉ số cũ!", "Ràng buộc dữ liệu!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCSD_Moi.Select();
                return;
            }

            if (CSN_Moi < CSN_Cu)
            {
                MessageBox.Show("Chỉ số nước mới không thể bé hơn chỉ số cũ!", "Ràng buộc dữ liệu!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCSN_Moi.Select();
                return;
            }


            List<CustomParameter> ls = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = idHopDong.ToString()
                },
                 new CustomParameter
                {
                    key = "@CSD_Moi",
                    value = CSD_Moi.ToString()
                },
                  new CustomParameter
                {
                    key = "@CSN_Moi",
                    value = CSN_Moi.ToString()
                }
            };

            
            if (db.ExeCute("ChotDienNuoc", ls) == 1)
            {
                this.Dispose();
                new frmThanhToan(idHopDong.ToString()).ShowDialog();
            }


        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
