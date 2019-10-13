using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Employee_ID { get; set; }
        public Employee Employee { get; set; }
        public string AccessType_ID { get; set; }
        public string Password { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeFullName
        {
            get
            {
                string fullName = $"{EmployeeFirstName} {EmployeeMiddleName} {EmployeeLastName}";
                return fullName.Replace("  ", " ");
            }
        }
        public string AccessTypeName { get; set; }

        public string Headers
        {
            get
            {
                return "Name,Employee_ID,AccessType_ID,Password";
            }
        }
    }
}
