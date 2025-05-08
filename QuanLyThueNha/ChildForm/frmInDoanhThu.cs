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
    public partial class frmInDoanhThu : Form
    {
        private DataTable dtDoanhThu;
        private string tongDoanhThu;
        public frmInDoanhThu(DataTable dtDoanhThu, string tongDoanhThu)
        {
            InitializeComponent();
            this.dtDoanhThu = dtDoanhThu;
            this.tongDoanhThu=tongDoanhThu;
        }

        private void frmInDoanhThu_Load(object sender, EventArgs e)
        {

            this.rpvDoanhThu.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local; // thiết lập chế độ xử lý là local
            this.rpvDoanhThu.LocalReport.ReportPath = "inDoanhThu.rdlc";//thiết lập đường dẫn của rpvDoanhThu là inDoanhThu.rdlc

            ReportParameter rp = new ReportParameter("ReportParameterTongDoanhThu", tongDoanhThu);
            ReportParameter rp1 = new ReportParameter("ReportParameterNgayLap", DateTime.Now.ToString("dd/MM/yyyy"));

            rpvDoanhThu.LocalReport.SetParameters(rp);
            rpvDoanhThu.LocalReport.SetParameters(rp1);

            ReportDataSource rds = new ReportDataSource
            {
                Name = "DataSet1",
                Value = dtDoanhThu
            };

            rpvDoanhThu.LocalReport.DataSources.Clear();
            rpvDoanhThu.LocalReport.DataSources.Add(rds);
            this.rpvDoanhThu.RefreshReport();



        }
    }
}
