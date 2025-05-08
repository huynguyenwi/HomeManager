using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNha
{
    public class Database
    {
        //dùng để kết nối sqlSever
        //private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyThueNha;Integrated Security=True;";
        private string connectionString = @"Data Source=RAZERBLADE15\HUY;Initial Catalog=QuanLyThueNha;Integrated Security=True;";


        //dùng để truy vấn
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;


        //hàm khởi tạo
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }
        }

        //hàm truy vấn dữ liệu trả về 1 bảng
        public DataTable SelectData(string sql, List<CustomParameter> lstPara = null)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure; 
                if (lstPara != null)
                {
                    foreach (var para in lstPara)
                    {
                        cmd.Parameters.AddWithValue(para.key, para.value);
                    }
                }

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        //hàm phục vụ thêm, update dl
        public int ExeCute(string sql, List<CustomParameter> lstPara = null)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara) 
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery(); 
                return (int)rs; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }


        //truy vấn trả về 1 dòng
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open(); 
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0]; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close(); 
            }
        }
    }
    public class CustomParameter
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}
