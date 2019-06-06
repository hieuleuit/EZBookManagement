using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net;
using BookstoreManagementApp_DAL;

namespace BookstoreManagementApp_Final_
{
    public partial class ManagerForm : Form
    {
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            dgv_st.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Khi click chọn 1 cell thì cả Row sẽ được chọn

            dgv_st.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Chế độ giãn cách đều dữ liệu theo kích thước của DataGridView

            dgv_st.DataSource = GetdataSV(); //Nguồn dữ liệu của DataGridView STAFF0 được lấy từ Cơ sở dữ liệu SQL được kết nối

            dgv_st.ReadOnly = true; //Không cho phép sửa chữa nội dung DataGridView
            // TODO: This line of code loads data into the 'ezManageDataSet.STAFF0' table. You can move, or remove it, as needed.
            bt_chart.BackColor = Color.FromArgb(0, 65, 120);
            bt_chart.ForeColor = Color.FromArgb(0, 65, 120);

            bt_nv.BackColor = Color.FromArgb(0, 65, 120);
            bt_nv.ForeColor = Color.FromArgb(0, 65, 120);

            bt_luong.BackColor = Color.FromArgb(0, 65, 120);
            bt_luong.ForeColor = Color.FromArgb(0, 65, 120);

            bt_csvc.BackColor = Color.FromArgb(0, 65, 120);
            bt_csvc.ForeColor = Color.FromArgb(0, 65, 120);

            bt_ql.Visible = false;
            bt_tk.Visible = false;

            dgv_st.Visible = false;

            pn_nv.Visible = false;

            loaddata();

            EXECUTEDATA("SELECT * FROM STAFF0 ORDER BY ID");
            dgv_st.Columns[0].HeaderText = "ID";
            dgv_st.Columns[1].HeaderText = "Họ & tên";
            dgv_st.Columns[2].HeaderText = "Ngày sinh";
            dgv_st.Columns[3].HeaderText = "Địa chỉ";
            dgv_st.Columns[4].HeaderText = "Giới tính";
            dgv_st.Columns[5].HeaderText = "SĐT";
            dgv_st.Columns[6].HeaderText = "Bậc lương";
            dgv_st.Columns[7].HeaderText = "Cấp độ"; //Phân quyền truy cập quản lý/nhân viên
            bt_savenv.Enabled = false;

        }

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
            else
            {
                e.Cancel = true; //Huỷ đóng form
            }
        }
       
        private void bt_nv_Click(object sender, EventArgs e)
        {
            bt_ql.Visible = true;
            bt_tk.Visible = true;
            dgv_st.Visible = true;

            pn_nv.Visible = true;
        }

        //public static string connectionstr = @"Data Source=DESKTOP-FG3GVU6;Initial Catalog=EzManage;Integrated Security=True";

        public SqlConnection NV_connectionString = new SqlConnection(ConnectionString.connectionString);

        private void OpenConnect() //Khởi tạo kết nối đến database
        {
            if (NV_connectionString.State == ConnectionState.Closed) //Sẽ được mở khi kết nối với database đang đóng 
            {
                NV_connectionString.Open(); //Hàm mở kết nối
            }
        }

        private void CloseConnect() //Đóng kết nối với database
        {
            if (NV_connectionString.State == ConnectionState.Open) //Sẽ được đóng khi kết nối với database đang mở 
            {
                NV_connectionString.Close(); //Hàm đóng kết nối
            }
        }

        DataSet GetdataSV() //DataSources của DataGridView
        {
            DataSet data = new DataSet();
            return data;
        }

        public Boolean EXECUTEDATA(string cmd) //Hàm để Execute query với câu lệnh là biến chuỗi cmd
        {
            OpenConnect(); //Mở kết nối với database
            Boolean check = false; //Giá trị đầu của biến check là false
            try
            {
                SqlCommand sc = new SqlCommand(cmd, NV_connectionString); // Khởi tạo biến sc để lưu giá trị của cmd và ConnectionString
                sc.ExecuteNonQuery(); //Execute query cmd
                check = true; //Sau khi execute thì trả về giá trị true
            }
            catch (Exception)
            {
                check = false;
            }
            CloseConnect(); //Đóng kết nối sau khi thực hiện hàm
            return check; //Trả về giá trị check của hàm Bool
        }

        public DataTable ReadData(string cmd)
        {
            OpenConnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, NV_connectionString);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            CloseConnect();
            return da;
        }

        private void loaddata() //Hàm để xuất data từ bảng DSSV
        {
            DataTable dt = ReadData("SELECT * FROM STAFF0");
            if (dt != null)
            {
                dgv_st.DataSource = dt;
            }
        }

        private void bt_addnv_Click(object sender, EventArgs e)
        {
            bt_savenv.Enabled = true;
            tb_name.Focus();
        }

        private void bt_savenv_Click(object sender, EventArgs e)
        {
            AddData(sender, e);
        }
        public void AddData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        {
            if (rb_female.Checked == true)
            {
                if (EXECUTEDATA("INSERT INTO STAFF0 VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','" + dtp.Value + "',N'Sài Gòn','1','" + tb_phone.Text + "','" + tb_bl.Text + "','" + tb_role.Text + "')") == true)
                {
                    bt_addnv.Visible = true;
                    //bt_edit.Enabled = true;
                    //bt_del.Enabled = true;
                    MessageBox.Show(dtp.Value.ToString());
                    MessageBox.Show("Đã thêm dữ liệu", "Thông báo");
                    loaddata();
                    return;
                }
                else
                {
                    //MessageBox.Show("INSERT INTO STAFF0 VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','1/1/11',N'Sài Gòn','2','" + tb_bl.Text + "','" + tb_role.Text + "')");
                    MessageBox.Show("Không thể thêm dữ liệu", "Thông báo");


                }
            }

            if (rb_male.Checked == true && tb_name.Text != String.Empty)
            {
                if (EXECUTEDATA("INSERT INTO STAFF0 VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','" + dtp.Value + "',N'Sài Gòn','2','" + tb_phone.Text + "','" + tb_bl.Text + "','" + tb_role.Text + "')") == true)
                {
                    bt_addnv.Visible = true;
                    //bt_edit.Enabled = true;
                    //bt_del.Enabled = true;

                    MessageBox.Show("Đã thêm dữ liệu", "Thông báo");
                    loaddata();
                    return;
                }
                else
                {
                    //MessageBox.Show("INSERT INTO STAFF0 VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','1/1/11',N'Sài Gòn','1','" + tb_bl.Text + "','" + tb_role.Text + "')");
                    MessageBox.Show("Không thể thêm dữ liệu", "Thông báo");

                }
            }
        }

        public string MSNV;

        //public void EditData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        //{
        //    if (rb_female.Checked == true)
        //    {
        //        if (EXECUTEDATA("UPDATE STAFF0 SET FULLNAME = N'" + tb_name.Text + "' WHERE ID  = " + ID + " " +
        //            " UPDATE STAFF0 SET [DOB] = '" + dtp.Value + "' WHERE ID  = " + ID + "" +
        //            " UPDATE STAFF0 SET [LOCA] = '" + tb_local.Text + "' WHERE ID  = " + ID + "" +
        //            " UPDATE STAFF0 SET [PHONE] = '" + tb_phone.Text + "' WHERE ID  = " + ID + "" +
        //            " UPDATE STAFF0 SET [SALARYLEVEL] = '" + tb_bl.Text + "' WHERE ID  = " + ID + "" +
        //            " UPDATE STAFF0 SET [ACCESSLEVEL] = '" + tb_role.Text + "' WHERE ID  = " + ID + "' ") == true)

        //        {
        //            MessageBox.Show("Đã sửa dữ liệu", "Thông báo"); //Nếu thêm dữ liệu thành công (Execute ... == true) thì hiện messagebox báo thêm thành công
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không thể sửa dữ liệu", "Thông báo");
        //        }
        //    }
        //    if (rb_male.Checked == true && rb_female.Checked = false

        //    if (rb_male.Checked == true && tb_name.Text != String.Empty)
        //    {
        //        if (EXECUTEDATA("INSERT INTO STAFF0 VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','" + dtp.Value + "',N'Sài Gòn','2','" + tb_phone.Text + "','" + tb_bl.Text + "','" + tb_role.Text + "')") == true)
        //        {
        //            bt_addnv.Visible = true;
        //            //bt_edit.Enabled = true;
        //            //bt_del.Enabled = true;

        //            MessageBox.Show("Đã thêm dữ liệu", "Thông báo");
        //            loaddata();
        //            return;
        //        }
        //        else
        //        {
        //            //MessageBox.Show("INSERT INTO STAFF0 VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','1/1/11',N'Sài Gòn','1','" + tb_bl.Text + "','" + tb_role.Text + "')");
        //            MessageBox.Show("Không thể thêm dữ liệu", "Thông báo");

        //        }
        //    }
        //}

        public void DeleteData(object sender, EventArgs e)
        {
            DialogResult DelData = MessageBox.Show("Bạn có muốn xóa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.YesNo); //Hiện thông báo xác nhận xóa
            if (DelData == DialogResult.Yes) //nếu chọn yes thì sẽ execute lệnh bên dưới để xóa
            {
                EXECUTEDATA("delete from STAFF0 where ID = '" + tb_id.Text + "'");
                MessageBox.Show("Đã xóa thành công", "Thông báo");//Hiện thông báo đã xóa
            }
        }

        private void bt_esave_Click(object sender, EventArgs e)
        {

        }

        private void bt_editnv_Click(object sender, EventArgs e)
        {
            MSNV = tb_id.Text;
        }

        private void bt_delnv_Click(object sender, EventArgs e)
        {
            DeleteData(sender,e);
            loaddata();
        }
        
    }
}
