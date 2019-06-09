using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BookstoreManagementApp_BUS;
using BookstoreManagementApp_DAL;

namespace BookstoreManagementApp_Final_
{
    public partial class ManagerForm : Form
    {
        Staff_account_BUS account = new Staff_account_BUS();
        int flag; //Cờ dùng để kiểm soát cho phép sửa giá trị trong textbox
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
            int flag = 0;
            Disable_Edit_Textbox();
            dgv_st.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Khi click chọn 1 cell thì cả Row sẽ được chọn

            dgv_st.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Chế độ giãn cách đều dữ liệu theo kích thước của DataGridView

            dgv_st.DataSource = GetdataSV(); //Nguồn dữ liệu của DataGridView STAFF được lấy từ Cơ sở dữ liệu SQL được kết nối

            dgv_st.ReadOnly = true; //Không cho phép sửa chữa nội dung DataGridView
            Customize_Button();

            //Ẩn các nút chức năng Thống kê, Lương, CSVC
            bt_ql.Visible = false;
            bt_tk.Visible = false;

            dgv_st.Visible = false;

            pn_nv.Visible = false;

            loaddata();

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
            //Đoạn này m viết
            //DataTable dt = ReadData("SELECT * FROM STAFF");
            //if (dt != null)
            //{
            //    dgv_st.DataSource = dt;
            //}
            //Dòng dưới t test
            dgv_st.DataSource = account.Get();
        }

        private void bt_addnv_Click(object sender, EventArgs e)
        {
            flag = 1; //Cho phép sửa dữ liệu trong textbox
            Disable_Edit_Textbox();
            pn_edit_save.Visible = false; //Khi chọn Thêm thì ẩn tính năng Sửa và Xoá đi
            bt_delnv.Visible = false;
            bt_addnv.Enabled = false;
            bt_savenv.Visible = true;
            //Xoá nội dung đang hiển thị trên các textbox để người dùng nhập dữ liệu mới
            tb_name.Text = "";
            tb_id.Text = "";
            tb_phone.Text = "";
            tb_role.Text = "";
            tb_bl.Text = "";
            dtp.Text = "";
            rb_male.Checked = true;
            tb_name.Focus();

        }

        private void bt_savenv_Click(object sender, EventArgs e)
        {
            AddData(sender, e);
            pn_edit_save.Visible = true; //Sau khi thêm thành công thì hiển thị lại nút Sửa, Xoá
            bt_delnv.Visible = true;
        }
        public void AddData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        {
            if (rb_female.Checked == true)
            {
                if (EXECUTEDATA("INSERT INTO STAFF VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','" + dtp.Value + "',N'Sài Gòn','2','" + tb_phone.Text + "','" + tb_bl.Text + "')") == true)
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
                    //MessageBox.Show("INSERT INTO STAFF VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','1/1/11',N'Sài Gòn','2','" + tb_bl.Text + "','" + tb_role.Text + "')");
                    MessageBox.Show("Không thể thêm dữ liệu", "Thông báo");


                }
            }
            else if (rb_male.Checked == true)
            {
                if (EXECUTEDATA("INSERT INTO STAFF VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','" + dtp.Value + "',N'Sài Gòn','1','" + tb_phone.Text + "','" + tb_bl.Text + "')") == true)
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
                    //MessageBox.Show("INSERT INTO STAFF VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','1/1/11',N'Sài Gòn','1','" + tb_bl.Text + "','" + tb_role.Text + "')");
                    MessageBox.Show("Không thể thêm dữ liệu", "Thông báo");

                }
            }
        }
        //public void EditData()
        //{
        //    string update = "UPDATE STAFF SET ID=@ID, FULLNAME=@FULLNAME, DOB=@DOB," +
        //        " LOCA=@LOCA, SEX=@SEX, PHONE=@PHONE, SALARYLEVEL=@SALARYLEVEL WHERE ID='{ID}'";
        //    SqlDataAdapter dataAdapter;
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            SqlCommand cmdUpdate = new SqlCommand(update, connection);
        //            cmdUpdate.Parameters.Add("@ID", SqlDbType.VarChar).Value = tb_id.Text;
        //            cmdUpdate.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = tb_name.Text;
        //            cmdUpdate.Parameters.Add("@DOB", SqlDbType.SmallDateTime).Value = dtp.Value;
        //            cmdUpdate.Parameters.Add("@LOCAL", SqlDbType.NVarChar).Value = tb_name.Text;
        //            cmdUpdate.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = tb_phone.Text;
        //            cmdUpdate.Parameters.Add("@SALARYLEVEL", SqlDbType.Float).Value = tb_bl.Text;
        //            if (rb_male.Checked == true)
        //            {
        //                cmdUpdate.Parameters.Add("@SEX", SqlDbType.Int).Value = "1";
        //            }
        //            else if (rb_female.Checked == true)
        //            {
        //                cmdUpdate.Parameters.Add("@SEX", SqlDbType.Int).Value = "2";
        //            }
        //            dataAdapter = new SqlDataAdapter(cmdUpdate);
        //            //dataAdapter.Fill(data);
        //            connection.Close();
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    MessageBox.Show("Complete");
        //    return;
        //}
        public string ID; //ID của nhân viên hiện đang được chọn để sửa thông tin

        public void EditData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        {
            if (rb_female.Checked == true)
            {
                if (EXECUTEDATA("UPDATE STAFF SET FULLNAME = N'" + tb_name.Text + "' WHERE ID  = " + ID + " " +
                    " UPDATE STAFF SET [DOB] = '" + dtp.Value + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [SEX] = '" + "1" + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [LOCA] = '" + "Sài gòn" + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [PHONE] = '" + tb_phone.Text + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [SALARYLEVEL] = '" + tb_bl.Text + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [ACCESSLEVEL] = '" + tb_role.Text + "' WHERE ID  = " + ID + "' ") == true)

                {
                    MessageBox.Show("Đã sửa dữ liệu", "Thông báo"); //Nếu thêm dữ liệu thành công (Execute ... == true) thì hiện messagebox báo thêm thành công
                }
                else
                {
                    MessageBox.Show("Không thể sửa dữ liệu female", "Thông báo");
                }
            }
            else if (rb_male.Checked == true)
            {
                if (EXECUTEDATA("UPDATE STAFF SET FULLNAME = N'" + tb_name.Text + "' WHERE ID  = " + ID + " " +
                    " UPDATE STAFF SET [DOB] = '" + dtp.Value + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [SEX] = '" + "0" + "' WHERE ID  = " + ID + "" +
                    //" UPDATE STAFF SET [LOCA] = '" + tb_local.Text + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [PHONE] = '" + tb_phone.Text + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [SALARYLEVEL] = '" + tb_bl.Text + "' WHERE ID  = " + ID + "" +
                    " UPDATE STAFF SET [ACCESSLEVEL] = '" + tb_role.Text + "' WHERE ID  = " + ID + "' ") == true)

                {
                    MessageBox.Show("Đã sửa dữ liệu", "Thông báo"); //Nếu thêm dữ liệu thành công (Execute ... == true) thì hiện messagebox báo thêm thành công
                }
                else
                {
                    MessageBox.Show("Không thể sửa dữ liệu male", "Thông báo");
                }
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");

            //if (rb_male.Checked == true && tb_name.Text != String.Empty)
            //    {
            //        if (EXECUTEDATA("INSERT INTO STAFF VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','" + dtp.Value + "',N'Sài Gòn','2','" + tb_phone.Text + "','" + tb_bl.Text + "','" + tb_role.Text + "')") == true)
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
            //            //MessageBox.Show("INSERT INTO STAFF VALUES (N'" + tb_id.Text + "',N'" + tb_name.Text + "','1/1/11',N'Sài Gòn','1','" + tb_bl.Text + "','" + tb_role.Text + "')");
            //            MessageBox.Show("Không thể thêm dữ liệu", "Thông báo");

            //        }
            //    }
        }

        public void DeleteData(object sender, EventArgs e)
        {
            DialogResult DelData = MessageBox.Show("Bạn có muốn xóa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.YesNo); //Hiện thông báo xác nhận xóa
            if (DelData == DialogResult.Yes) //nếu chọn yes thì sẽ execute lệnh bên dưới để xóa
            {
                if (EXECUTEDATA("DELETE FROM STAFF WHERE ID = '" + tb_id.Text + "'"))
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo");//Hiện thông báo đã xóa
                }
                else
                {
                    MessageBox.Show("Không thể xoá nhân viên này", "Thông báo");
                }
                //EXECUTEDATA("DELETE FROM STAFF WHERE ID = '" + tb_id.Text + "'");
                //MessageBox.Show("Đã xóa thành công", "Thông báo");//Hiện thông báo đã xóa
            }
        }

        private void bt_editnv_Click(object sender, EventArgs e)
        {
            flag = 1; //Cho phép sửa dữ liệu trong textbox
            Disable_Edit_Textbox();
            pn_add_save.Visible = false; //Khi chọn Sửa thì ẩn tính năng Thêm và Xoá đi
            bt_delnv.Visible = false;
            bt_editnv.Enabled = false;
            bt_esave.Visible = true;
            bt_esave.Enabled = true;
            ID = tb_id.Text;
            tb_name.Focus();
        }

        private void bt_esave_Click(object sender, EventArgs e)
        {
            ID = tb_id.Text;
            EditData(sender, e);
            pn_add_save.Visible = true; //Sau khi sửa xong thì hiển thị lại Thêm và Xoá
            bt_delnv.Visible = true;
        }

        private void bt_delnv_Click(object sender, EventArgs e)
        {
            DeleteData(sender, e);
            loaddata();
        }

        private void dgv_st_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                ///////////////////////////////////////////////////
                ID = string.Copy(dgv_st.Rows[index].Cells["ID"].Value.ToString());
                tb_id.Text = dgv_st.Rows[index].Cells["ID"].Value.ToString();
                tb_name.Text = dgv_st.Rows[index].Cells["FULLNAME"].Value.ToString();
                dtp.Text = dgv_st.Rows[index].Cells["DOB"].Value.ToString();
                tb_phone.Text = dgv_st.Rows[index].Cells["PHONE"].Value.ToString();
                tb_bl.Text = dgv_st.Rows[index].Cells["SALARYLEVEL"].Value.ToString();
                if (rb_male.Text == dgv_st.Rows[index].Cells["SEX"].Value.ToString())
                {
                    rb_male.Checked = true;
                }
                else if (rb_female.Text == dgv_st.Rows[index].Cells["SEX"].Value.ToString())
                {
                    rb_female.Checked = true;
                }
            }
        }

        private void dgv_st_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                ///////////////////////////////////////////////////
                ID = string.Copy(dgv_st.Rows[index].Cells["ID"].Value.ToString());
                tb_id.Text = dgv_st.Rows[index].Cells["ID"].Value.ToString();
                tb_name.Text = dgv_st.Rows[index].Cells["FULLNAME"].Value.ToString();
                dtp.Text = dgv_st.Rows[index].Cells["DOB"].Value.ToString();
                tb_phone.Text = dgv_st.Rows[index].Cells["PHONE"].Value.ToString();
                tb_bl.Text = dgv_st.Rows[index].Cells["SALARYLEVEL"].Value.ToString();
                if (rb_male.Text == dgv_st.Rows[index].Cells["SEX"].Value.ToString())
                {
                    rb_male.Checked = true;
                }
                else if (rb_female.Text == dgv_st.Rows[index].Cells["SEX"].Value.ToString())
                {
                    rb_female.Checked = true;
                }
            }
        }

        private void Disable_Edit_Textbox()
        {
            if (flag == 0) //Không cho phép sửa các giá trị trên textbox
            {
                tb_name.Enabled = false;
                tb_id.Enabled = false;
                tb_phone.Enabled = false;
                tb_role.Enabled = false;
                tb_bl.Enabled = false;
                dtp.Enabled = false;
                rb_male.Enabled = false;
                rb_female.Enabled = false;
            }
            else if (flag == 1) //Cho phép sửa các giá trị trên textbox
            {
                tb_name.Enabled = true;
                tb_id.Enabled = true;
                tb_phone.Enabled = true;
                tb_role.Enabled = true;
                tb_bl.Enabled = true;
                dtp.Enabled = true;
                rb_male.Enabled = true;
                rb_female.Enabled = true;
            }

        }
    }
}
