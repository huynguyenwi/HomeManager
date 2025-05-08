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
    public partial class frmCauHinh : Form
    {
        private Database db;

        private string idCauHinh;
      
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void LoadDSCauHinh()
        {
            db = new Database();

            DataTable dt = db.SelectData("LoadDSCauHinh");

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                idCauHinh = row["IDCauHinh"].ToString();

                lblTenKhuQuanLy.Text = row["TenKhuQuanLy"].ToString();
                lblTenQuanLy.Text = row["TenQuanLy"].ToString();
                lblDiaChiKhuQuanLy.Text = row["DiaChiKhuQuanLy"].ToString();
                lblSoDienThoai.Text = row["SoDienThoai"].ToString();
                lblDonGiaDien.Text = string.Format("{0:N0} VNĐ", int.Parse(row["DonGiaDien"].ToString()));
                lblDonGiaNuoc.Text = string.Format("{0:N0} VNĐ", int.Parse(row["DonGiaNuoc"].ToString()));
                lblTienVeSinh.Text = string.Format("{0:N0} VNĐ", int.Parse(row["TienVeSinh"].ToString()));
                lblTienMang.Text = string.Format("{0:N0} VNĐ", int.Parse(row["TienMang"].ToString()));
               

                // Ẩn nút "Thêm Mới" nếu đã có cấu hình
                btnThemMoi.Enabled = false;
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
            }
            else
            {
                // Hiển thị nút "Thêm Mới" nếu chưa có cấu hình
                btnThemMoi.Enabled = true;
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;

                ResetLabels();
            }

        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            LoadDSCauHinh();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmXuLyCauHinh(null).ShowDialog();//truyền tham số null vào để xác định trường hợp thêm cấu hình
            LoadDSCauHinh();

            // Kiểm tra và ẩn nút "Thêm Mới" nếu đã có cấu hình
            DataTable dt = db.SelectData("LoadDSCauHinh");
            if (dt.Rows.Count > 0)
            {
                btnThemMoi.Enabled = false;
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            new frmXuLyCauHinh(idCauHinh).ShowDialog();//truyền idCauHinh đc chọn qua form frmXuLyCauHinh để xác định trường hợp cập nhật cấu hình
            LoadDSCauHinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa cấu hình này hay không?",
               "Xác nhận xóa",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<CustomParameter> lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idCauHinh",
                        value = idCauHinh
                    }
                };
                int rs = db.ExeCute("DeleteCauHinh", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa cấu hình thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSCauHinh();

                    // Cập nhật trạng thái các nút sau khi xóa cấu hình
                    DataTable dt = db.SelectData("LoadDSCauHinh");
                    if (dt.Rows.Count == 0)
                    {
                        btnThemMoi.Enabled = true;
                        btnXoa.Enabled = false;
                        btnCapNhat.Enabled = false;

                        ResetLabels();
                    }
                }
            }
        }

        private void ResetLabels()
        {
            lblTenKhuQuanLy.Text = "Khu Vip";
            lblTenQuanLy.Text = "Nguyễn Văn A";
            lblDiaChiKhuQuanLy.Text = "Hà Nội";
            lblSoDienThoai.Text = "0";
            lblDonGiaDien.Text = "0";
            lblDonGiaNuoc.Text = "0";
            lblTienVeSinh.Text = "0";
            lblTienMang.Text = "0";
        }

    }
}
