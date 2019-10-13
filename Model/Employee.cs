using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Position_ID { get; set; }
        public string PositionName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {MiddleName} {LastName}";
                return fullName.Replace("  ", " ");
            }
        }

        public string Headers
        {
            get
            {
                return "LastName,FirstName,MiddleName,Position_ID,ContactNumber,EmailAddress";
            }
        }
    }
}
