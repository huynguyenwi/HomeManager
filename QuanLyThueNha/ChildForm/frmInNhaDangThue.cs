using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNha.ChildForm
{
    public partial class frmInNhaDangThue : Form
    {
       
        private DataTable dtNhaDangThue;
        
        public frmInNhaDangThue(DataTable dtNhaDangThue)
        {
            InitializeComponent();
           
            this.dtNhaDangThue = dtNhaDangThue;
        }

        private void InNhaDangThue_Load(object sender, EventArgs e)
        {
           
            this.rpvNhaDangThue.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local; // thiết lập chế độ xử lý là local
            this.rpvNhaDangThue.LocalReport.ReportPath = "inNhaDangThue.rdlc";//thiết lập đường dẫn của rpvNhaDangThue là inNhaDangThue.rdlc

            
            ReportParameter rp = new ReportParameter("ReportParameterNgayLap", DateTime.Now.ToString("dd/MM/yyyy"));

            rpvNhaDangThue.LocalReport.SetParameters(rp);
    

            ReportDataSource rds = new ReportDataSource
            {
                Name = "DataSet1", 
                Value = dtNhaDangThue
            };

            rpvNhaDangThue.LocalReport.DataSources.Clear();
            rpvNhaDangThue.LocalReport.DataSources.Add(rds);
            this.rpvNhaDangThue.RefreshReport();

            
        }
    }
}
