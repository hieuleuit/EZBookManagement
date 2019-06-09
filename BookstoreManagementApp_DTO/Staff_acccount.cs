using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    public class Staff_acccount
    {
     //   ID VARCHAR(20) PRIMARY KEY NOT NULL,
     //   FULLNAME NVARCHAR(50) NOT NULL,
     //   DOB SMALLDATETIME NOT NULL, 
	    //LOCA NVARCHAR(50) NOT NULL, ---Địa chỉ

     //   SEX INT NOT NULL, ---Giá trị 1 tương ứng với giới tính Nam, 2 tương ứng với Nữ

     //   PHONE VARCHAR(20) NOT NULL,
     //   SALARYLEVEL FLOAT NOT NULL, ---Bậc lương
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string fullname;
        public string FULLNAME
        {
            get { return fullname; }
            set { fullname = value; }
        }

        private string date_of_birth;
        public string DOB
        {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }

        private string location;
        public string LOCA
        {
            get { return location; }
            set { location = value; }
        }

        private int sex;
        public int SEX
        {
            get { return sex; }
            set { sex = value; }
        }

        private string phone_number;
        public string PHONE
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        private float salary_level;
        public float SALARYLEVEL
        {
            get { return salary_level; }
            set { salary_level = value; }
        }
    }
}
