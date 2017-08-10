using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTest.Models
{
    public class EmployeeDetailsModel
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public long Mobile_Number { get; set; }
        public long AlternateMobileNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Current_Country { get; set; }
        public string Home_Country { get; set; }
        public int ZipCode { get; set; }
    }
}
