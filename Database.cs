using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Database
    {
        private string connectionString = @"Data Source=DESKTOP-DP6F07U;Initial Catalog = QuanLySinhVien; Integrated Security = True";
        private SqlConnection connection;
        private DataTable tbl;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Failed: " + ex.Message);
            }
            finally 
            {
                connection.Close();
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> lst)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lst)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());
                return tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());
                return tbl.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public int Excute(string sql, List<CustomParameter> lst)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lst)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
