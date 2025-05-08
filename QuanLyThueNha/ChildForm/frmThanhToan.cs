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
    public partial class frmThanhToan : Form
    {
        private string IDThueNha;
        private Database db;
        private DataRow dr;
        private string tienNha, tienDien, tienNuoc, tienVeSinh, tienMang, tongTienCuaThang ,soNoCuaNhungThangTruoc, tongTienCanThanhToan, daThanhToan, conNo;

        public frmThanhToan(string IDThueNha)
        {
            this.IDThueNha = IDThueNha;
            db = new Database();
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        private void LoadHopDongThueNha()
        {
            List<CustomParameter> lst = new List<CustomParameter> {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = IDThueNha
                }
            };

            dr = db.SelectData("LoadHopDong", lst).Rows[0];
           
            lblPhong.Text = dr["TenNha"].ToString();
            lblTenKhachHang.Text = dr["HoTenKH"].ToString();
            lblTienNha.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["GiaNha"].ToString()));
            lblTienDien.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienDien"].ToString()));
            lblTienNuoc.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienNuoc"].ToString()));
            lblTienVeSinh.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienVeSinh"].ToString()));
            lblTienMang.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienMang"].ToString()));
            lblTongTienThang.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TongTienCuaThang"].ToString()));
            lblSoDuNo.Text = string.Format("{0:N0} VNĐ", dr["SoNoConThieu"].ToString().Length == 0 ? 0 : int.Parse(dr["SoNoConThieu"].ToString()));
            lblTongTienCanThanhToan.Text = string.Format("{0:N0} VNĐ", dr["TongTienPhaiTra"].ToString().Length == 0 ? int.Parse(dr["TongTienCuaThang"].ToString()) : int.Parse(dr["TongTienPhaiTra"].ToString()));
            lblConLai.Text = string.Format("{0:N0} VNĐ", dr["TongTienPhaiTra"].ToString().Length == 0 ? int.Parse(dr["TongTienCuaThang"].ToString()) : int.Parse(dr["TongTienPhaiTra"].ToString()));


            tienNha = lblTienNha.Text;
            tienDien = lblTienDien.Text;
            tienNuoc = lblTienNuoc.Text;
            tienVeSinh = lblTienVeSinh.Text;
            tienMang = lblTienMang.Text;
            tongTienCuaThang = lblTongTienThang.Text;
            soNoCuaNhungThangTruoc = lblSoDuNo.Text;
            tongTienCanThanhToan = lblTongTienCanThanhToan.Text;
            conNo = lblConLai.Text;
            
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadHopDongThueNha();
        }

        
        private void txtThanhToan_KeyUp(object sender, KeyEventArgs e)
        {
            string canThanhToan = lblTongTienCanThanhToan.Text;
            int soNo = int.Parse(canThanhToan.Split(' ')[0].Replace(",", ""));

            lblConLai.Text = string.Format("{0:N0} VNĐ", soNo - int.Parse(txtThanhToan.Text.Trim().Length == 0 ? "0" : txtThanhToan.Text));


            conNo = lblConLai.Text;
        }

        private void txtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThanhToanTraNha_Click(object sender, EventArgs e)
        {
            if (txtThanhToan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền mà khách đã thanh toán!!");
                return;
            }


            int tongNo = int.Parse(lblTongTienCanThanhToan.Text.Split(' ')[0].Replace(",", ""));
            int soThanhToan = int.Parse(txtThanhToan.Text);

            

            bool ok = true;
    
            if (soThanhToan != tongNo && MessageBox.Show("Số tiền khách thanh toán chưa đủ so với số nợ!! Vui lòng thanh toán đủ trước khi trả nhà!!",
                "Thông báo!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                ok = false;
            }
            if (ok)
            {
                List<CustomParameter> ls = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        key = "@idHopDong",
                        value = IDThueNha
                    },
                    new CustomParameter
                    {
                        key = "@soTienTra",
                        value = soThanhToan.ToString()
                    }

                };

                daThanhToan = soThanhToan.ToString();
                

                if (db.ExeCute("ThanhToanVaTraNha", ls) >= 1)
                {
                    if (MessageBox.Show("Thanh toán và trả nhà thành công! \n Bạn muốn in hóa đơn không?", "Thông báo!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
                    {
                        this.Dispose();
                        frmInHoaDonThanhToan fInHoaDonThanhToan = new frmInHoaDonThanhToan(dr, tienNha, tienDien, tienNuoc, tienVeSinh, tienMang,
                            tongTienCuaThang,soNoCuaNhungThangTruoc, tongTienCanThanhToan, daThanhToan, conNo);
                        fInHoaDonThanhToan.ShowDialog();
                    }
                     else
                    {
                        this.Dispose();
                    }

                }
                else
                {
                    MessageBox.Show("Thanh toán và trả nhà thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            if (txtThanhToan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền cần thanh toán!");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = IDThueNha
                },
                 new CustomParameter
                 {
                     key = "@soTien",
                     value = txtThanhToan.Text
                 }
            };

            daThanhToan = txtThanhToan.Text;

            int kq = db.ExeCute("ThanhToanGiaHan", lst);
            if (kq >= 1)
            {
                if(MessageBox.Show("Thanh toán và gia hạn thành công! \n Bạn muốn in hóa đơn không?", "Thông báo!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Dispose();
                    frmInHoaDonThanhToan fInHoaDonThanhToan = new frmInHoaDonThanhToan(dr, tienNha, tienDien, tienNuoc, tienVeSinh, tienMang,
                            tongTienCuaThang, soNoCuaNhungThangTruoc, tongTienCanThanhToan, daThanhToan, conNo);
                    fInHoaDonThanhToan.ShowDialog();
                }
                else 
                {
                    this.Dispose();
                }
                
            }
            else
            {
                MessageBox.Show("Thanh toán và gia hạn thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
