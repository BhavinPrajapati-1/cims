using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models
{
    public class UnitProgressModel
    {
        public int ID { get; set; }
        public string UploadDate { get; set; }
        public int Unit_ID { get; set; }
        public string UnitName { get; set; }
        public string UnitAddress { get; set; }
        public int UnitType_ID { get; set; }
        public string UnitTypeName { get; set; }
        public int UnitStatus_ID { get; set; }
        public string UnitStatusName { get; set; }
        public byte[] Image { get; set; }
        public string Notes { get; set; }
        public int Employee_ID { get; set; }
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


        public string Headers
        {
            get
            {
                return "ID,UploadDate,Unit_ID,Image,Status_ID,Notes,User_ID";
            }
        }
    }
}
