using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BookstoreManagementApp_DAL;

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
        //Đặt màu nền cho button
        private void Customize_Button()
        {
            bt_chart.BackColor = Color.FromArgb(0, 65, 120);
            bt_chart.ForeColor = Color.FromArgb(0, 65, 120);

            bt_nv.BackColor = Color.FromArgb(0, 65, 120);
            bt_nv.ForeColor = Color.FromArgb(0, 65, 120);

            bt_luong.BackColor = Color.FromArgb(0, 65, 120);
            bt_luong.ForeColor = Color.FromArgb(0, 65, 120);

            bt_csvc.BackColor = Color.FromArgb(0, 65, 120);
            bt_csvc.ForeColor = Color.FromArgb(0, 65, 120);
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            Customize_Button();
            lb_slr_us.Text = data.user;
            lb_slr_id.Text = ReadDataa("SELECT ID FROM PASSWORD WHERE PASSWORD.USERNAME = '" + data.user + "'").ToString();
        }

        public static DataTable ReadData_slr(string cmd)
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

        public static object ReadDataa(string cmd)
        {
            OpenConnect();
            DataTable da = new DataTable();

            SqlCommand sc = new SqlCommand(cmd, NV_connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sda.Fill(da);
            object id = sc.ExecuteScalar();

            CloseConnect();
            return id;
        }

        //private void loaddata_slr() //Hàm để xuất data từ bảng DSSV
        //{
        //    DataTable dt = ReadData_slr("SELECT FULLNAME, ID FROM STAFF ORDER BY ID");
        //    if (dt != null)
        //    {
        //        dgw_slr.DataSource = dt;
        //    }

        //    dgw_slr.Columns[0].HeaderText = "ID";
        //    dgw_slr.Columns[1].HeaderText = "Họ & tên";
        //}

        /*private void loaddata_slr_temp() //Hàm để xuất data từ bảng DSSV
        {
            DataTable dt = ReadData_slr("SELECT STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), SUM(WTIME), STAFF.LCB, STAFF.ADDS, STAFF.SALARYLEVEL FROM STAFF, STAFFLOG  WHERE MONTH(LOGINTIME) = '" + cbb_slr_m.SelectedItem.ToString() + "' AND YEAR(LOGINTIME) = '" + cbb_slr_y.SelectedItem.ToString() + "' AND STAFF.ID = STAFFLOG.ID GROUP BY STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), STAFF.LCB, STAFF.ADDS, STAFF.SALARYLEVEL");
            if (dt != null)
            {
                dgv_slr_temp.DataSource = dt;
            }
        }
        
        public void Showdata_nv()
        {
            Load_Data_From_Database();

            //EXECUTEDATA("SELECT FULLNAME, ID FROM STAFF ORDER BY ID ");

            EXECUTEDATA("SELECT * FROM STAFF ORDER BY ID");
            dgv_st.Columns[0].HeaderText = "ID";
            dgv_st.Columns[1].HeaderText = "Họ & tên";
            dgv_st.Columns[2].HeaderText = "Ngày sinh";
            dgv_st.Columns[3].HeaderText = "Địa chỉ";
            dgv_st.Columns[4].HeaderText = "Giới tính";
            dgv_st.Columns[5].HeaderText = "SĐT";
            dgv_st.Columns[6].HeaderText = "Bậc lương";
            //dgv_st.Columns[7].HeaderText = "Cấp độ"; //Phân quyền truy cập quản lý/nhân viên
            bt_savenv.Visible = false;
            //bt_esave.Visible = false;
        }
        */

        // Sự kiện khi người dùnng ấn nút log out tk
        /*private void LogoutButton_Click(object sender, EventArgs e)
        {
            logouttime = DateTime.Now.ToString();
            if (LoginAccountForm.who == 0)
            {
                EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_slr_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','0','" + data.user + "','')");
                EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");

            }
            else if (LoginAccountForm.who == 1)
            {
                EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_slr_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','1','" + data.user + "','')");
                EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
            }
            LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất khi người dùng đăng xuất tk

            this.Dispose(); // Tắt form đang thao tác

            loginForm.Show(); // Xuất form đăng nhập
        }
        */
        

        //public static string connectionstr = @"Data Source=DESKTOP-FG3GVU6;Initial Catalog=EzManage;Integrated Security=True";

        public static SqlConnection NV_connectionString = new SqlConnection(ConnectionString.connectionString);

        public static void OpenConnect() //Khởi tạo kết nối đến database
        {
            if (NV_connectionString.State == ConnectionState.Closed) //Sẽ được mở khi kết nối với database đang đóng 
            {
                NV_connectionString.Open(); //Hàm mở kết nối
            }
        }

        public static void CloseConnect() //Đóng kết nối với database
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
        DataSet GetdataSV_slr() //DataSources của DataGridView
        {
            DataSet data = new DataSet();
            return data;
        }

        public static void EXECUTEDATAA(string cmd) //Hàm để Execute query với câu lệnh là biến chuỗi cmd
        {
            OpenConnect(); //Mở kết nối với database

            SqlCommand sc = new SqlCommand(cmd, NV_connectionString); // Khởi tạo biến sc để lưu giá trị của cmd và ConnectionString
            sc.ExecuteNonQuery(); //Execute query cmd

            CloseConnect(); //Đóng kết nối sau khi thực hiện hàm
        }

        public static Boolean EXECUTEDATA(string cmd) //Hàm để Execute query với câu lệnh là biến chuỗi cmd
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


        /*private void bt_luong_Click(object sender, EventArgs e)
        {
            pn_main.Visible = false;
            pn_slr.Visible = true;
            bt_ql.Visible = false;
            bt_tk.Visible = false;

            mvalue = Convert.ToInt32(ReadDataa("SELECT MIN(VALUEE) FROM(SELECT YEAR(LOGINTIME) AS VALUEE FROM STAFFLOG) AVC"));

            for (int i = 0; i <= DateTime.Now.Year - mvalue + 1; i++)
            {

                cbb_slr_y.Items.Add((mvalue + i).ToString());
            }
            //cbb_slr_m.DisplayMember = cbb_slr_m.Items[0].ToString();
            //cbb_slr_y.Text = ReadDataa("SELECT MIN(VALUEE) FROM(SELECT YEAR(LOGINTIME) AS VALUEE FROM STAFFLOG) AVC").ToString();
        }
        */
        //private void dgw_slr_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int numrow;
        //    numrow = e.RowIndex;
        //    tb_slr_name.Text = dgw_slr.Rows[numrow].Cells[1].Value.ToString();
        //    tb_slr_id.Text = dgw_slr.Rows[numrow].Cells[2].Value.ToString();
        //    tb_slr_bl.Text = dgw_slr.Rows[numrow].Cells[2].Value.ToString();
        //    tb_slr_lcb.Text = dgw_slr.Rows[numrow].Cells[2].Value.ToString();
        //    tb_slr_pc.Text = dgw_slr.Rows[numrow].Cells[2].Value.ToString();
        //    tb_slr_tl.Text = dgw_slr.Rows[numrow].Cells[2].Value.ToString();
        //}

        private void bt_slr_xem_Click(object sender, EventArgs e)
        {
            //loaddata_slr_temp();
            //Calslr();
        }
        public DataSet GetStaff_SLR()
        {
            DataSet data = new DataSet();
            string query = "SELECT FULLNAME, ID FROM STAFF ORDER BY ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        /*
        private void Calslr()
        {
            if (EXECUTEDATA("INSERT INTO SALARY (ID, MONTH, YEAR, TOTALTIME,BS,ADDS, SALARYLV) SELECT STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), SUM(WTIME), STAFF.LCB, STAFF.ADDS, STAFF.SALARYLEVEL FROM STAFF, STAFFLOG  WHERE MONTH(LOGINTIME) = '6' AND YEAR(LOGINTIME) = '2020' AND STAFF.ID = STAFFLOG.ID GROUP BY STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), STAFF.LCB, STAFF.ADDS, STAFF.SALARYLEVEL"))
            {
                EXECUTEDATAA("UPDATE SALARY SET SLR = [BS]*[TOTALTIME]*[SALARYLV]+[ADDS]");
                DataTable dt = ReadData_slr("SELECT ID, MONTH, YEAR, TOTALTIME, BS, ADDS, SALARYLV, SLR FROM SALARY WHERE WHERE MONTH = '" + cbb_slr_m.SelectedItem.ToString() + "' AND YEAR = '" + cbb_slr_y.SelectedItem.ToString() + "'");
                if (dt != null)
                {
                    
                    dgv_slr.DataSource = dt;
                    dgv_slr.Columns[0].HeaderText = ("Mã nhân viên");
                    dgv_slr.Columns[1].HeaderText = ("Tháng");
                    dgv_slr.Columns[2].HeaderText = ("Năm");
                    dgv_slr.Columns[3].HeaderText = ("Tổng giờ làm");
                    dgv_slr.Columns[4].HeaderText = ("Lương cơ bản");
                    dgv_slr.Columns[5].HeaderText = ("Phụ cấp");
                    dgv_slr.Columns[6].HeaderText = ("Bậc lương");
                    dgv_slr.Columns[7].HeaderText = ("Tổng lương");
                }


            }
            else
            {
                DataTable dt = ReadData_slr("SELECT * FROM SALARY WHERE MONTH = '" + cbb_slr_m.SelectedItem.ToString() + "' AND YEAR = '" + cbb_slr_y.SelectedItem.ToString() + "'");
                if (dt != null)
                {
                    dgv_slr.DataSource = dt;

                    dgv_slr.Columns[0].HeaderText = ("Mã nhân viên");
                    dgv_slr.Columns[1].HeaderText = ("Tháng");
                    dgv_slr.Columns[2].HeaderText = ("Năm");
                    dgv_slr.Columns[3].HeaderText = ("Tổng giờ làm");
                    dgv_slr.Columns[4].HeaderText = ("Lương cơ bản");
                    dgv_slr.Columns[5].HeaderText = ("Phụ cấp");
                    dgv_slr.Columns[6].HeaderText = ("Bậc lương");
                    dgv_slr.Columns[7].HeaderText = ("Tổng lương");
                }
            }

        }
        
        private void dgv_slr_temp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow != 0 && numrow < dgv_slr_temp.Rows.Count - 1)
            {
                tb_slr_id.Text = dgv_slr_temp.Rows[numrow].Cells[0].Value.ToString();
                tb_slr_name.Text = ReadDataa("SELECT STAFF.FULLNAME FROM STAFF WHERE ID = '" + dgv_slr_temp.Rows[numrow].Cells[0].Value.ToString() + "'").ToString();
                tb_slr_bl.Text = dgv_slr_temp.Rows[numrow].Cells[7].Value.ToString();
                tb_slr_lcb.Text = dgv_slr_temp.Rows[numrow].Cells[4].Value.ToString();
                tb_slr_pc.Text = dgv_slr_temp.Rows[numrow].Cells[5].Value.ToString();
                tb_slr_tl.Text = dgv_slr_temp.Rows[numrow].Cells[6].Value.ToString();
            }

        }
        */
        // Sự kiện khi ng dùng tắt form
        public static string logouttime;
        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                logouttime = DateTime.Now.ToString();
                if (LoginAccountForm.who == 0)
                {
                    EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_slr_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','0','" + data.user + "','')");
                    EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
                }
                else if (LoginAccountForm.who == 1)
                {
                    EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_slr_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','1','" + data.user + "','')");
                    EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
                }
                LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất ra 

                loginForm.Show();

                return;
            }
            else
            {
                e.Cancel = true; //Huỷ đóng form
            }
        }
        //Khởi tạo các User Control
        UserControl userControl_Staff = new UC_Staff();
        UserControl userControl_Salary = new UC_Salary();
        UserControl userControl_CSVC = new UC_CSVC();
        //UserControl userControl_Chart = new UC_Chart();
        //Các hàm thao tác với User Control trên Panel chính - pn_main
        //Khi click vào Tab Nhân viên thì hiển thị User Control tương ứng
        private void bt_nv_Click(object sender, EventArgs e)
        {
            userControl_Staff.Show(); //Hiển thị User Control UC_Staff
            //Ẩn các User Control còn lại
            userControl_Salary.Hide(); 
            userControl_CSVC.Hide();
            //userControl_Chart.Hide();
            //Xoá sạch các controls đang nằm trong pn_main
            pn_main.Controls.Clear();
            //Thêm User Control UC_Staff vào pn_main
            pn_main.Controls.Add(userControl_Staff);
        }
        private void bt_luong_Click(object sender, EventArgs e)
        {

            userControl_Staff.Hide();
            userControl_Salary.Show();
            userControl_CSVC.Hide();
            //userControl_Chart.Hide();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(userControl_Salary);
        }
        private void bt_csvc_Click(object sender, EventArgs e)
        {
            userControl_Staff.Hide();
            userControl_Salary.Hide();
            userControl_CSVC.Show();
            //userControl_Chart.Hide();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(userControl_CSVC);
        }
        private void bt_chart_Click(object sender, EventArgs e)
        {
            userControl_Staff.Hide();
            userControl_Salary.Hide();
            userControl_CSVC.Hide();
            //userControl_Chart.Show();
            pn_main.Controls.Clear();
            //pn_main.Controls.Add(userControl_Chart);
        }
    }
    
}
//680th line