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
    public class EmployeePassManage_DAL // Class để thực hiện những thao tác với tk của nhân viên
    {
        // List để lưu dữ liệu mật khẩu truy xuất từ database (xét xem nhân viên có nhập đúng mk đăng nhập hay không)
        List<EmployeePassword> employeesPassword = new List<EmployeePassword>();

        // Hàm để lưu thông tin password của nhân viên lấy từ database
        public void AddEmployeePassToList()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) // khởi tạo kết nối đến database
            {
                connection.Open(); // mở kết nối đến database

                string passwordSelect = "Select * from MATKHAUNV";

                SqlCommand passwordList = new SqlCommand(passwordSelect, connection); // Truy xuất dữ liệu từ database
                SqlDataReader passwordReader = passwordList.ExecuteReader(); // biến để đọc dữ liệu truy xuất và lưu vào list

                while (passwordReader.Read())
                {
                    EmployeePassword employee = new EmployeePassword(); // biến để lưu trữ các thông tin được đọc ra và đưa vào list

                    employee.EmployeeUserName = (string)passwordReader["USERNAME"]; // đọc dữ liệu đã truy xuất
                    employee.EmployeePass = (string)passwordReader["PASS"];
                    employee.AccessLevel = (int)passwordReader["ACCESSLEVEL"];

                    employeesPassword.Add(employee); // Lưu dữ liệu đã đọc vào list
                }

                connection.Close(); // ngắt kết nối đến database
            }
        }

        //bool CheckUser = false; // Biến để check lại xem user đăng nhập đã đúng hay chưa
        // Hàm để log in vào mật khẩu của nhân viên
        public int LoginAccount(string UserName, string Password)
        {
            AddEmployeePassToList(); // Gọi hàm để add thông tin tk user vào list để xét đăng nhập

            //Vòng lặp để xét xem mật khẩu và user name đã dc nhập đúng hay chưa(xét từ đầu tới cuối)
            for (int i = 0; i < employeesPassword.Count; i++)
            {
                // Nếu nhập đúng thì ẩn form nhập password và hiển thị form tiếp theo
                if (employeesPassword[i].EmployeeUserName == UserName && employeesPassword[i].EmployeePass == Password)
                {
                    //CheckUser = true;

                    // Xét xem phân quyền là admin hay nhân viên để trả về giá trị tương ứng và gọi form tương ứng
                    if (employeesPassword[i].AccessLevel == 0)
                    {
                        return 0; // return 0 trong TH là nhân viên
                    }

                    else
                        return 1;
                }
            }

            return 2; // return 1 trong TH là quản lý
        }
    }
}
