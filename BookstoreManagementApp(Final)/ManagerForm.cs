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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
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

        // Sự kiện khi ng dùng tắt form
        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất ra 

                loginForm.Show();

                return;
            }
        }
    }
}
