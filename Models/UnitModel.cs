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
        public int Type_ID { get; set; }
        public string TypeName { get; set; }
        public string Address { get; set; }
        public int Status_ID { get; set; }
        public string StatusName { get; set; }
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
