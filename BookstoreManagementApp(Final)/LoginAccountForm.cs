using BookstoreManagementApp_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementApp_Final_
{
    public partial class LoginAccountForm : Form
    {
        public LoginAccountForm()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi vẽ rắn lên hình thì sẽ không bị nháy

            // Khởi tạo màu để Textbox cùng màu với form
            UserNameTxb.BackColor = Color.FromArgb(242, 242, 242);
            PasswordTxb.BackColor = Color.FromArgb(242, 242, 242);

            UserNameTxb.Select(); // Focus đến ô đăng nhập user name
        }

        // Khai báo form để xét xem ng đăng nhập là nv hay quản lý để gọi form tương ứng
        EmployeeForm employeeForm = new EmployeeForm();
        ManagerForm managerForm = new ManagerForm();

        EmployeePassManage_BUS Employee = new EmployeePassManage_BUS(); // Biến để gọi các thao tác với sự kiện

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Nếu ng đăng nhập là nhân viên
            if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 0)
            {
                this.Hide();

                employeeForm.Show();
            }

            // Nếu tk đăng nhập là quản lý
            else if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 1)
            {
                this.Hide();

                managerForm.Show();
            }

            // Nếu tk đăng nhập là ko hợp lệ
            else
            {
                MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng! Vui lòng nhập lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Sau khi kiểm tra hết các tk có trong database nếu không giống cái nào thì reset lại ô nhập
                UserNameTxb.Text = "";
                PasswordTxb.Text = "";

                UserNameTxb.Select(); // Focus lại vào ô nhập user name

                return;
            }
        }

        // Sự kiện đế bắt lệnh Enter (nếu ng dùng nhấn Enter thì ta xét username và password)
        private void UserNameTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // Nếu ng đăng nhập là nhân viên
                if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 0)
                {
                    this.Hide();

                    employeeForm.Show();
                }

                // Nếu tk đăng nhập là quản lý
                else if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 1)
                {
                    this.Hide();

                    managerForm.Show();
                }

                // Nếu tk đăng nhập là ko hợp lệ
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng! Vui lòng nhập lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Sau khi kiểm tra hết các tk có trong database nếu không giống cái nào thì reset lại ô nhập
                    UserNameTxb.Text = "";
                    PasswordTxb.Text = "";

                    UserNameTxb.Select(); // Focus lại vào ô nhập user name

                    return;
                }
            }
        }

        // Sự kiện đế bắt lệnh Enter (nếu ng dùng nhấn Enter thì ta xét username và password)
        private void PasswordTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // Nếu ng đăng nhập là nhân viên
                if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 0)
                {
                    this.Hide();

                    employeeForm.Show();
                }

                // Nếu tk đăng nhập là quản lý
                else if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 1)
                {
                    this.Hide();

                    managerForm.Show();
                }

                // Nếu tk đăng nhập là ko hợp lệ
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng! Vui lòng nhập lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Sau khi kiểm tra hết các tk có trong database nếu không giống cái nào thì reset lại ô nhập
                    UserNameTxb.Text = "";
                    PasswordTxb.Text = "";

                    UserNameTxb.Select(); // Focus lại vào ô nhập user name

                    return;
                }
            }
        }

        // Sự kiện nếu ng dùng tắt form đăng nhập và thoát ứng dụng
        private void LoginAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
