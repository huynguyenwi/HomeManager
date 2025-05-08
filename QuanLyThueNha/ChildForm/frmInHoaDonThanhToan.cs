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
    public partial class frmInHoaDonThanhToan : Form
    {
        private DataRow dr;
        private string tienNha, tienDien, tienNuoc, tienVeSinh, tienMang, tongTienCuaThang, soNoCuaNhungThangTruoc, tongTienCanThanhToan, daThanhToan, conNo;



        public frmInHoaDonThanhToan(DataRow dr, string tienNha, string tienDien, string tienNuoc, string tienVeSinh, string tienMang, string tongTienCuaThang,
            string soNoCuaNhungThangTruoc, string tongTienCanThanhToan, string daThanhToan, string conNo)
        {
            InitializeComponent();
            this.dr = dr;
            this.tienNha = tienNha;
            this.tienDien = tienDien;
            this.tienNuoc = tienNuoc;
            this.tienVeSinh = tienVeSinh;
            this.tienMang = tienMang;
            this.tongTienCuaThang = tongTienCuaThang;
            this.soNoCuaNhungThangTruoc = soNoCuaNhungThangTruoc;
            this.tongTienCanThanhToan = tongTienCanThanhToan;
            this.daThanhToan = daThanhToan;
            this.conNo = conNo;
        }

        private void frmInHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            this.rpvỊnHoaDonThanhToan.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local; // thiết lập chế độ xử lý là local
            this.rpvỊnHoaDonThanhToan.LocalReport.ReportPath = "inHoaDonThanhToan.rdlc";//thiết lập đường dẫn của rpvỊnHoaDonThanhToan là inHoaDonThanhToan.rdlc

            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("ReportParameterTienNha", tienNha),
                new ReportParameter("ReportParameterTienDien", tienDien),
                new ReportParameter("ReportParameterTienNuoc", tienNuoc),
                new ReportParameter("ReportParameterTienVeSinh", tienVeSinh),
                new ReportParameter("ReportParameterTienMang", tienMang),
                new ReportParameter("ReportParameterTongTIenCuaThang", tongTienCuaThang),
                new ReportParameter("ReportParameterSoNoCuaNhungThangTruoc", soNoCuaNhungThangTruoc),
                new ReportParameter("ReportParameterTongTienCanThanhToan", tongTienCanThanhToan),
                new ReportParameter("ReportParameterDaThanhToan", daThanhToan),
                new ReportParameter("ReportParameterConNo", conNo),
                new ReportParameter("ReportParameterNgayLap", DateTime.Now.ToString("dd/MM/yyyy"))
            };

            // thêm tham số vào báo cáo
            rpvỊnHoaDonThanhToan.LocalReport.SetParameters(reportParameters);

            DataTable dt = dr.Table.Clone(); //Tạo một DataTable và thêm DataRow vào nó
            dt.ImportRow(dr);

            ReportDataSource rds = new ReportDataSource
            {
                Name = "DataSet1",
                Value = dt
            };

            rpvỊnHoaDonThanhToan.LocalReport.DataSources.Clear();
            rpvỊnHoaDonThanhToan.LocalReport.DataSources.Add(rds);
            this.rpvỊnHoaDonThanhToan.RefreshReport();
        }
    }
}
