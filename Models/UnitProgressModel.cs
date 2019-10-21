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
        public object Image { get; set; }
        public int ImageExists { get; set; }
        public bool HasImage
        {
            get
            {
                bool result = Convert.ToInt32(ImageExists) == 1 ? true : false;
                return result;
            }
        }
        public string Notes { get; set; }
        public int User_ID { get; set; }
        
        public string Headers
        {
            get
            {
                return "ID,UploadDate,Unit_ID,Image,Status_ID,Notes,User_ID";
            }
        }
    }
}
