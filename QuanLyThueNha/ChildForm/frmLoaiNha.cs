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
    public partial class frmLoaiNha : Form
    {
        private Database db;
        private int xacNhan = 0;

        private int maLoaiNha = 0;

        public frmLoaiNha()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xacNhan = 1;
            txtDonGia.ReadOnly = false;
            txtTenLoaiNha.ReadOnly = false;

            txtDonGia.Text = "0";
            txtTenLoaiNha.Text = null;

            btnCapNhat.Enabled = btnThem.Enabled = false;
            btnXacNhan.Enabled = true;
        }

        private void LoadDsLoaiNha()
        {
            db = new Database();

            string timKiem = txtTimKiem.Text.Trim();
            List<CustomParameter> lstPra = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };

            DataTable dt = db.SelectData("TimKiemLoaiNha", lstPra);

            dgvDsLoaiNha.Font = new Font("Arial", 9, FontStyle.Regular);

            dgvDsLoaiNha.DataSource = dt;

        }


        private void frmLoaiNha_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = btnThem.Enabled = true;
            btnXacNhan.Enabled = false;

            db = new Database();

            LoadDsLoaiNha();
            dgvDsLoaiNha.Columns[0].Width = 100;//set bề rộng cho cột id loại nhà
            dgvDsLoaiNha.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiNha.Columns[0].HeaderText = "Mã loại";

            dgvDsLoaiNha.Columns[2].Width = 200;
            dgvDsLoaiNha.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiNha.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDsLoaiNha.Columns[2].HeaderText = "Đơn giá";

            dgvDsLoaiNha.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDsLoaiNha.Columns[1].HeaderText = "Tên loại Nhà";

            txtDonGia.ReadOnly = true;
            txtTenLoaiNha.ReadOnly = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDsLoaiNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maLoaiNha = int.Parse(dgvDsLoaiNha.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenLoaiNha.Text = dgvDsLoaiNha.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDsLoaiNha.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            xacNhan = -1;
            txtDonGia.ReadOnly = false;
            txtTenLoaiNha.ReadOnly = false;

            btnCapNhat.Enabled = btnThem.Enabled = false;
            btnXacNhan.Enabled = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenLoaiNha = txtTenLoaiNha.Text.Trim();
            int donGia = int.Parse(txtDonGia.Text);


            //ràng buộc dữ liệu            

            if (string.IsNullOrEmpty(tenLoaiNha))
            {
                MessageBox.Show("Vui lòng nhập tên loại nhà", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (donGia < 50000)
            {
                MessageBox.Show("Đơn giá tối thiểu phải là 50.000", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<CustomParameter> prList = new List<CustomParameter>();

            if (xacNhan == 1)//trường hợp thêm mới loại nhà
            {
                prList.Add(new CustomParameter
                {
                    key = "@tenLoaiNha",
                    value = tenLoaiNha
                });
                prList.Add(new CustomParameter
                {
                    key = "@giaNha",
                    value = donGia.ToString()
                });
                int rs = db.ExeCute("ThemLoaiNha", prList);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới loại nhà thành công!", "Thông báo!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
           if (xacNhan == -1)//cập nhật nhà
            {
                if (maLoaiNha == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhà cần cập nhật", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                prList.Add(new CustomParameter()
                {
                    key = "@idLoaiNha",
                    value = maLoaiNha.ToString()
                });
                prList.Add(new CustomParameter
                {
                    key = "@tenLoaiNha",
                    value = tenLoaiNha
                });
                prList.Add(new CustomParameter
                {
                    key = "@giaNha",
                    value = donGia.ToString()
                });
                int rs = db.ExeCute("CapNhatLoaiNha", prList);
                if (rs == 1)
                {
                    MessageBox.Show("Cập nhật loại nhà thành công!", "Thông báo!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            LoadDsLoaiNha();
            txtDonGia.Text = "0";
            txtTenLoaiNha.Text = null;
            maLoaiNha = 0;
            txtDonGia.ReadOnly = true;
            txtTenLoaiNha.ReadOnly = true;

            btnCapNhat.Enabled = btnThem.Enabled = true;
            btnXacNhan.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maLoaiNha == 0)
            {
                MessageBox.Show("Vui lòng chọn loại nhà cần xóa", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa loại nhà này hay không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<CustomParameter> lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiNha",
                        value = maLoaiNha.ToString()
                    }
                };
                int rs = db.ExeCute("DeleteLoaiNha", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa loại nhà thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsLoaiNha();
                    maLoaiNha = 0;//reset mã loại nhà (id nhà về giá trị mặc định)
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDsLoaiNha();
        }
    }
}
