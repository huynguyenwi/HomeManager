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
    public partial class frmNha : Form
    {
        private Database db;

        private int rowIndex = -1;//biến lưu chỉ số nhà của nhà đc chọn
        public frmNha()
        {
            InitializeComponent();
        }

        private void LoadDsNha()
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

            DataTable dt = db.SelectData("LoadDSNha", lstPra);

            dgvNha.Font = new Font("Arial", 9, FontStyle.Regular);

            dgvNha.DataSource = dt;

        }

        private void frmNha_Load(object sender, EventArgs e)
        {
            LoadDsNha();

            #region gui
            //dat lai ten cot
            dgvNha.Columns["IDNha"].HeaderText = "Mã nhà";
            dgvNha.Columns["TenLoaiNha"].HeaderText = "Loại nhà";
            dgvNha.Columns["TenNha"].HeaderText = "Nhà";
            dgvNha.Columns["GiaNha"].HeaderText = "Đơn giá";
            dgvNha.Columns["TrangThai"].HeaderText = "Trạng thái";

            //set kích thước các cột
            dgvNha.Columns["IDNha"].Width = 100;
            dgvNha.Columns["TenLoaiNha"].Width = 200;
            dgvNha.Columns["GiaNha"].Width = 200;
            dgvNha.Columns["TrangThai"].Width = 200;

            dgvNha.Columns["TenNha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên nhà tự động co giãn theo form 


            //căn chỉnh vị trí của cột
            dgvNha.Columns["GiaNha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;//căn phải cho cột đơn giá

            //định dạng phần nghìn cho cột đơn giá nhà
            dgvNha.Columns["GiaNha"].DefaultCellStyle.Format = "N0";
            #endregion
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmXuLyNha(null).ShowDialog();//truyền tham số null vào để xác định trường hợp thêm mới nhà
            LoadDsNha();
        }

       

        private void dgvNha_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id nhà đc chọn
            string idNha = dgvNha.Rows[e.RowIndex].Cells["IDNha"].Value.ToString();
            new frmXuLyNha(idNha).ShowDialog();//truyền idNha đc chọn qua form frmXuLyNha để xác định trường hợp cập nhật nhà
            LoadDsNha();
        }

        private void dgvNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id nhà cần xóa trong sự kiện cell click của datagridview
            rowIndex = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kiểm tra xem rowIndex có phải < 0 hay không
            //nếu < 0 có nghĩa chưa có nhà nào được chọn để xóa cả vì chỉ số dòng phải bắt đầu từ 0
            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cần xóa", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//nếu gặp trường hợp chưa có nhà nào đc chọn để xóa thì sẽ dừng chương trình ngang đây
            }

            // Kiểm tra nếu dòng được chọn không phải là dòng mới (thường được sử dụng để thêm dòng mới trong DataGridView)
            if (dgvNha.Rows[rowIndex].IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn nhà cần xóa", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Nếu là dòng mới, dừng chương trình
            }

            //nếu có nhà được chọn để xóa ( ngược lại trường hợp trên) thì hiện câu hỏi xác nhận xóa
            if (MessageBox.Show("Bạn có chắc muốn xóa nhà " + dgvNha.Rows[rowIndex].Cells["tennha"].Value.ToString() + " hay không?", "Xác nhận xóa nhà", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //tương tự, chúng ta cần truyền giá trị id nhà cần xóa vào proc vừa mới khai báo
                List<CustomParameter> lstPara = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        key = "@idNha",
                        value = dgvNha.Rows[rowIndex].Cells["IDNha"].Value.ToString()
                    }
                };
                int kq = db.ExeCute("DeleteNha", lstPara);

                //hiển thị thông báo trong trường hợp xóa thành công
                if (kq == 1)
                {
                    MessageBox.Show("Xóa nhà thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //sau khi xóa thành công thì load lại ds nhà hiện tại bằng cách gọi lại hàm  LoadDsNha
                    LoadDsNha();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDsNha();
        }
    }
}
