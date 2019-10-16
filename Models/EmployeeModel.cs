using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
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
