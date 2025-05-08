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
    public partial class frmXuLyNha : Form
    {
        private string idNha;
        private Database db;
        public frmXuLyNha(string idNha)
        {
            this.idNha = idNha;

            InitializeComponent();
        }

        private void frmXuLyNha_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiNha();

            if (string.IsNullOrEmpty(idNha))//nếu idNha đc truyền qua là null = trường hợp thêm mới
            {
                lblTitle.Text = "Thêm nhà mới";
            }
            else//nếu idNha khác null <=> trường hợp cập nhật thông tin nhà
            {
                lblTitle.Text = "Cập nhật thông tin nhà";


                List<CustomParameter> lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idNha",
                        value = idNha
                    }
                };

                DataTable dt = db.SelectData("SelectNha", lstPara);

                if (dt.Rows.Count > 0) // Kiểm tra nếu có dữ liệu trả về
                {
                    DataRow row = dt.Rows[0]; //lấy hàng có chỉ số 0 trong datatable

                    // Set các dữ liệu lấy được cho các component trên form frmXuLyNha
                    cbbLoaiNha.SelectedValue = row["IDLoaiNha"].ToString(); // set id loại nhà cho combobox
                    txtTenNha.Text = row["TenNha"].ToString(); // set giá trị tên nhà cho textbox txtTenNha
                    ckbHoatDong.Checked = row["trangthai"].ToString() == "1"; // set trạng thái hoạt động cho checkbox ckbHoatDong
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhà!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose(); // đóng form nếu không tìm thấy dữ liệu
                }
            }
        }
        private void LoadLoaiNha()
        {
            DataTable dt = db.SelectData("LoadDSLoaiNha");
            cbbLoaiNha.DataSource = dt;
            cbbLoaiNha.DisplayMember = "TenLoaiNha";
            cbbLoaiNha.ValueMember = "IDLoaiNha";
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); //đóng form lại
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose(); //đóng form lại
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbbLoaiNha.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại nhà", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idLoaiNha = cbbLoaiNha.SelectedValue.ToString();
            string tenNha = txtTenNha.Text.Trim();
            int trangThai = ckbHoatDong.Checked ? 1 : 0;

            if (string.IsNullOrEmpty(tenNha))
            {
                MessageBox.Show("Vui lòng nhập tên nhà", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNha.Select();
                return;
            }


            if (string.IsNullOrEmpty(idNha))//trường hợp thêm mới nhà không có idNha <=> null
            {
                List<CustomParameter> lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiNha",
                        value = idLoaiNha
                    },
                    new CustomParameter()
                    {
                        key = "@tenNha",
                        value = tenNha
                    },
                    new CustomParameter()
                    {
                        key = "@trangThai",
                        value = trangThai.ToString()
                    }
                };
                int rs = db.ExeCute("ThemMoiNha", lstPra);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới nhà thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset lại các giá trị của component sau khi thêm mới thành công
                    txtTenNha.Text = null;
                    cbbLoaiNha.SelectedIndex = 0;
                }
            }
            else//trường hợp cập nhật nhà đã tồn tại <=> idNha có giá trị # null
            {
                List<CustomParameter> lstPara = new List<CustomParameter>()
                {
                   new CustomParameter
                   {
                       key = "@idNha",
                       value = idNha
                   },
                    new CustomParameter
                   {
                       key = "@idLoaiNha",
                       value = cbbLoaiNha.SelectedValue.ToString()
                   },
                   new CustomParameter
                   {
                       key = "@tenNha",
                       value = txtTenNha.Text
                   },
                   new CustomParameter
                   {
                       key = "@trangThai",
                       value = trangThai.ToString()
                   }
               };
                int kq = db.ExeCute("UpdateNha", lstPara);
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin nhà thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo thành công
                    this.Dispose();//đóng form frmXyLyNha
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhà không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo không thành công
                }
            }
        }
    }
}
