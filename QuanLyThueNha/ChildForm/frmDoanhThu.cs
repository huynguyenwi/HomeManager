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
    public partial class frmDoanhThu : Form
    {
        private Database db;
        private DataTable dtDoanhThu;
        private string tongDoanhThu;
        public frmDoanhThu()
        {
            InitializeComponent();
        }
      

        private void LoadDoanhThu()
        {
            DateTime ngayBatDau = dtpkNgayBatDau.Value;
            DateTime ngayKetThuc = dtpkNgayKetThuc.Value;

            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@NgayBatDau",
                    value = dtpkNgayBatDau.Value.ToString("yyyy-MM-dd")
                },
                new CustomParameter
                {
                    key = "@NgayKetThuc",
                    value = dtpkNgayKetThuc.Value.ToString("yyyy-MM-dd")
                }
            };

            dgvDoanhThu.AutoGenerateColumns = false;
            dtDoanhThu = db.SelectData("ThongKeDoanhThuTheoKhoangThoiGian", lst);
            dgvDoanhThu.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvDoanhThu.DataSource = dtDoanhThu;

            if (dtDoanhThu == null ||  dtDoanhThu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian này.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TinhTongDoanhThu()
        {
            DateTime ngayBatDau = dtpkNgayBatDau.Value;
            DateTime ngayKetThuc = dtpkNgayKetThuc.Value;

            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@NgayBatDau",
                    value = dtpkNgayBatDau.Value.ToString("yyyy-MM-dd")
                },
                new CustomParameter
                {
                    key = "@NgayKetThuc",
                    value = dtpkNgayKetThuc.Value.ToString("yyyy-MM-dd")
                }
            };

            DataTable dtTongDoanhThu = db.SelectData("TongDoanhThu", lst);

            if (dtTongDoanhThu != null && dtTongDoanhThu.Rows.Count > 0 && dtTongDoanhThu.Rows[0]["TongDoanhThu"] != DBNull.Value)
            {
                tongDoanhThu = string.Format("{0:N0} VNĐ", int.Parse(dtTongDoanhThu.Rows[0]["TongDoanhThu"].ToString()));
                txtTongDoanhThu.Text = tongDoanhThu;
            }
            else
            {
                txtTongDoanhThu.Text = "0 VNĐ";
            }
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDoanhThu();
            TinhTongDoanhThu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
            TinhTongDoanhThu();
        }


        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            frmInDoanhThu fInDoanhThu = new frmInDoanhThu(dtDoanhThu, tongDoanhThu);
            fInDoanhThu.ShowDialog();
        }
    }
}
