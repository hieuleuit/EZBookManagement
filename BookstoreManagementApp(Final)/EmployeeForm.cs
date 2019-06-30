using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using BookstoreManagementApp_BUS;
using BookstoreManagementApp_DAL;

using BookstoreManagementApp_DTO;

namespace BookstoreManagementApp_Final_
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi vẽ rắn lên hình thì sẽ không bị nháy
        }

        // Sự kiện khi người dùnng ấn nút log out tk
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất khi người dùng đăng xuất tk

            this.Dispose(); // Tắt form đang thao tác

            loginForm.Show(); // Xuất form đăng nhập
        }
        string logouttime;
        // Sự kiện khi ng dùng tắt form
        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                logouttime = DateTime.Now.ToString();
                if (LoginAccountForm.who == 0)
                {
                    ManagerForm.EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + label2.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','0','" + data.user + "','')");
                    ManagerForm.EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");

                }
                else if (LoginAccountForm.who == 1)
                {
                    ManagerForm.EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + label2.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','1','" + data.user + "','')");
                    ManagerForm.EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
                }
                LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất ra 

                loginForm.Show();

                return;
            }
        }

        // Khai báo form quản lý và xuất
        EmployeeManageForm manageForm = new EmployeeManageForm();
        // Khai báo form bán hàng và xuất
        EmployeeSaleForm saleForm = new EmployeeSaleForm();

        // Sự kiện khi nhân viên ấn vào nút để mở form quản lý của nhân viên
        private void ManageButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Tắt form đang sử dụng

            manageForm.Show();

            manageForm.FormClosing += ManageForm_FormClosing; // Gọi sự kiện nếu ng dùng có tắt form manage
        }

        // Sự kiện nếu ng dùng tăt form manage
        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xét nếu form chỉnh của nhân viên đang ẩn thì hiện lại
                if (this.Visible == false)
                {
                    this.Show();
                }
            }
        }

        // Sự kiện khi nhân viên ấn vào nút để mở form bán hàng của nhân viên
        private void SaleButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Tắt form đang sử dụng

            saleForm.Show();

            saleForm.FormClosing += SaleForm_FormClosing; // Gọi sự kiện nếu ng dùng có tắt form sale
        }

        // Sự kiện nếu ng dùng tắt form sale
        private void SaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xét nếu form chỉnh của nhân viên đang ẩn thì hiện lại
                if (this.Visible == false)
                {
                    this.Show();
                }
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            label1.Text = data.user;
            label2.Text = ManagerForm.ReadDataa("SELECT ID FROM PASSWORD WHERE PASSWORD.USERNAME = '"+data.user+"'").ToString();
            //textBox1.Text = ("SELECT STAFF.ID FROM STAFF, PASSWORD WHERE PASSWORD.USERNAME = '" + data.user + "'");
        }
        
    }
}
