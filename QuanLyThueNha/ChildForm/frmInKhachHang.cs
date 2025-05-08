using Microsoft.Reporting.WinForms;
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
    public partial class frmInKhachHang : Form
    {
        DataTable dtKhachHang;

        public frmInKhachHang(DataTable dtKhachHang)
        {
            InitializeComponent();
            this.dtKhachHang = dtKhachHang;
        }

        private void frmInKhachHang_Load(object sender, EventArgs e)
        {
            this.rpvKhachHang.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local; // thiết lập chế độ xử lý là local
            this.rpvKhachHang.LocalReport.ReportPath = "inKhachHang.rdlc";//thiết lập đường dẫn của rpvKhachHang là inKhachHang.rdlc


            ReportParameter rp = new ReportParameter("ReportParameterNgayLap", DateTime.Now.ToString("dd/MM/yyyy"));

            rpvKhachHang.LocalReport.SetParameters(rp);


            ReportDataSource rds = new ReportDataSource
            {
                Name = "DataSet1",
                Value = dtKhachHang
            };

            rpvKhachHang.LocalReport.DataSources.Clear();
            rpvKhachHang.LocalReport.DataSources.Add(rds);
            this.rpvKhachHang.RefreshReport();

            
        }
    }
}
