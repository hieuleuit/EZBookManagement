using BookstoreManagementApp_DAL;
using BookstoreManagementApp_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class EmployeePassManage_BUS
    {
        Account_manage_DAL Account = new Account_manage_DAL(); // Đối tượng để thực thi các thao tác đối với GUI

        // Hàm gọi khi người dùng đăng nhập vào ứng dụng
        public int LoginAccount(string UserName, string Password)
        {
            return Account.LoginAccount(UserName, Password);
            
        }
        
    }
}
