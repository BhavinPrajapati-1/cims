using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models
{
    public class UnitModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int UnitType_ID { get; set; }
        public string UnitTypeName { get; set; }
        public string Address { get; set; }
        public int UnitStatus_ID { get; set; }
        public int ImageExists { get; set; }
        public bool HasImage
        {
            get
            {
                bool result = Convert.ToInt32(ImageExists) ==1 ? true : false;
                return result;
            }
        }
        public string UnitStatusName { get; set; }
        public string StartDate { get; set; }
        public string CompletionDate { get; set; }

        public string Headers
        {
            get
            {
                return "ID,Name,Type_ID,Address,Status_ID,StartDate,CompletionDate";
            }
        }
    }
}
