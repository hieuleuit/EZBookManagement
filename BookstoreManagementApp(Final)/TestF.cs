using BookstoreManagementApp_BUS;
using BookstoreManagementApp_DAL;
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

namespace BookstoreManagementApp_Final_
{
    public partial class TestF : Form
    {
        public TestF()
        {
            InitializeComponent();
        }
        DataSet Get_Info() //Lấy thông tin SV từ sql database
        {
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            DataSet data = new DataSet();
            //Lay du lieu tu sql db
            Staff_account_BUS temp = new Staff_account_BUS();
            data = temp.Get();
            return data;
        }

    }
    }
}
