using BookstoreManagementApp_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BookstoreManagementApp_DAL
{
    public class Staff_info
    {
        List<Staff_acccount> List_staffs = new List<Staff_acccount>();
        //public void Get_Staff_Info()
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        connection.Open();
        //        string Select_all = "SELECT * from STAFF";
        //        SqlCommand sqlcmd = new SqlCommand(Select_all, connection); // Truy xuất dữ liệu từ database
        //        SqlDataReader Data_reader = sqlcmd.ExecuteReader(); // biến để đọc dữ liệu truy xuất và lưu vào list

        //        while (Data_reader.Read())
        //        {
        //            Staff_acccount temp = new Staff_acccount(); // biến để lưu trữ các thông tin được đọc ra và đưa vào list
        //            temp.ID = (string)Data_reader["ID"]; // Đọc dữ liệu đã truy xuất
        //            temp.FULLNAME = (string)Data_reader["FULLNAME"];
        //            temp.DOB = (string)Data_reader["DOB"];
        //            temp.LOCA = (string)Data_reader["LOCA"];
        //            temp.SEX = (int)Data_reader["SEX"];
        //            temp.PHONE = (string)Data_reader["PHONE"];
        //            temp.SALARYLEVEL = (float)Data_reader["SALARYLEVEL"];

        //            List_staffs.Add(temp);
        //        }
        //        connection.Close();
        //    }
        //}
        public DataSet GetStaff()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT * from STAFF";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public void Add_New_Staff_Info(string ID, string FULLNAME, string DOB, string LOCA, int SEX, string PHONE, float SALARYLEVEL)
        {
            string Insert_into = "INSERT INTO STAFF VALUES (@ID, @FULLNAME, @DOB, @LOCA, @SEX, @PHONE, @SALARYLEVEL)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.SmallDateTime).Value = DOB;
                    cmdInsert.Parameters.Add("@LOCA", SqlDbType.NVarChar).Value = LOCA;
                    cmdInsert.Parameters.Add("@SEX", SqlDbType.Int).Value = SEX;
                    cmdInsert.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = PHONE;
                    cmdInsert.Parameters.Add("@SALARYLEVEL", SqlDbType.Float).Value = SALARYLEVEL;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Delete_Staff_Info(string ID)
        {
            string Delete = "DELETE FROM STAFF WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Update_Staff_Info(string ID, string FULLNAME, string DOB, string LOCA, int SEX, string PHONE, float SALARYLEVEL)
        {
            string Insert_into = "UPDATE STAFF SET FULLNAME=@FULLNAME, DOB=@DOB, LOCA=@LOCA, SEX=@SEX, PHONE=@PHONE, SALARYLEVEL=@SALARYLEVEL WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.SmallDateTime).Value = DOB;
                    cmdInsert.Parameters.Add("@LOCA", SqlDbType.NVarChar).Value = LOCA;
                    cmdInsert.Parameters.Add("@SEX", SqlDbType.Int).Value = SEX;
                    cmdInsert.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = PHONE;
                    cmdInsert.Parameters.Add("@SALARYLEVEL", SqlDbType.Float).Value = SALARYLEVEL;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
