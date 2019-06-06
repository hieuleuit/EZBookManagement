using BookstoreManagementApp_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementApp_DAL
{
    public class Account_manage_DAL // Class để thực hiện những thao tác với tk của nhân viên
    {
        // List để lưu dữ liệu mật khẩu truy xuất từ database (xét xem nhân viên có nhập đúng mk đăng nhập hay không)
        List<Account> List_accounts = new List<Account>();

        // Hàm để lưu thông tin password của nhân viên lấy từ database
        public void Get_Account_Info() //Lấy thông tin tài khoản nhân viên từ database, thêm nó vào list "Account"
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) // khởi tạo kết nối đến database
            {
                connection.Open(); // Mở kết nối đến database

                string Select_all = "Select * from MATKHAUNV";

                SqlCommand sqlcmd = new SqlCommand(Select_all, connection); // Truy xuất dữ liệu từ database
                SqlDataReader Data_reader = sqlcmd.ExecuteReader(); // biến để đọc dữ liệu truy xuất và lưu vào list

                while (Data_reader.Read())
                {
                    Account Staff = new Account(); // biến để lưu trữ các thông tin được đọc ra và đưa vào list

                    Staff.UserName = (string)Data_reader["USERNAME"]; // đọc dữ liệu đã truy xuất
                    Staff.Password = (string)Data_reader["PASS"];
                    Staff.AccessLevel = (int)Data_reader["ACCESSLEVEL"];

                    List_accounts.Add(Staff); // Lưu dữ liệu đã đọc vào list "Account"
                }

                connection.Close(); // Đóng kết nối đến database
            }
        }

        //bool CheckUser = false; // Biến để check lại xem user đăng nhập đã đúng hay chưa
        // Hàm để log in vào mật khẩu của nhân viên
        public int LoginAccount(string UserName, string Password)
        {
            Get_Account_Info(); // Gọi hàm để add thông tin tk user vào list để xét đăng nhập

            //Vòng lặp để xét xem mật khẩu và user name đã dc nhập đúng hay chưa(xét từ đầu tới cuối)
            for (int i = 0; i < List_accounts.Count; i++)
            {
                // Nếu nhập đúng thì ẩn form nhập password và hiển thị form tiếp theo
                if (List_accounts[i].UserName == UserName && List_accounts[i].Password == Password)
                {
                    //CheckUser = true;

                    // Xét xem phân quyền là admin hay nhân viên để trả về giá trị tương ứng và gọi form tương ứng
                    if (List_accounts[i].AccessLevel == 0)
                    {
                        return 0; // return 0 trong TH là nhân viên
                    }

                    else
                        return 1;
                }
            }

            return 2; // return 1 trong TH là quản lý
        }
        //Account temp_account = new Account();
        //string password = "";
        
        //private string username = "";
        //private string savedPassword = "$2a$10$mdvPjWsllunjF2x7sqpU2umPCud5NF9IRsjXvPeA/MLL9dsNicRka";
        //private string savedPassword2 = "$2a$10$3WGn/jRe86MqREEjUXfi2OHkp0oHFIIpHDmg7cLfHn4vIp4f93sJ6";

        //private void btLogin_Click(object sender, EventArgs e)
        //private void BCrypt_Verify()
        //{
        //    bool checkPass = BCrypt.Net.BCrypt.Verify(tb2.Text.ToString(), savedPassword);
        //    if (checkPass)
        //    {
        //        MessageBox.Show("Password Correct!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Password Incorrect");
        //    }
        //}
    }
}
