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
    public partial class EmployeeManageForm : Form
    {
        public EmployeeManageForm()
        {
            InitializeComponent();

            // Disable các nút chức năng
            ManageButton.Enabled = false;
            SearchButton.Enabled = false;
            ReportButton.Enabled = false;
            SaleButton.Enabled = false;
        }
    }
}
