using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_M4_L1_L4
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Office OfficeId { get; set; }
        public Title TitleId { get; set; }
    }
}
