using Microsoft.Reporting.WinForms;
using QuanLyThueNha.Objects;
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
    public partial class frmInNhaChuaThue : Form
    {
        DataTable dtNhaChuaThue;
        public frmInNhaChuaThue(DataTable dtNhaChuaThue)
        {
            InitializeComponent();
            this.dtNhaChuaThue = dtNhaChuaThue;
        }

        private void frmInNhaChuaThue_Load(object sender, EventArgs e)
        {
            this.rpvNhaChuaThue.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local; // thiết lập chế độ xử lý là local
            this.rpvNhaChuaThue.LocalReport.ReportPath = "inNhaChuaThue.rdlc";//thiết lập đường dẫn của rpvNhaChuaThue là inNhaChuaThue.rdlc


           
            ReportParameter rp = new ReportParameter("ReportParameterNgayLap", DateTime.Now.ToString("dd/MM/yyyy"));

            rpvNhaChuaThue.LocalReport.SetParameters(rp);



            ReportDataSource rds = new ReportDataSource
            {
                Name = "DataSet1",
                Value = dtNhaChuaThue
            };

            rpvNhaChuaThue.LocalReport.DataSources.Clear();
            rpvNhaChuaThue.LocalReport.DataSources.Add(rds);
            this.rpvNhaChuaThue.RefreshReport();

        }
    }
}
