using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Model
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public string Headers
        {
            get
            {
                return "Name,Address,ContactNumber";
            }
        }
    }
}
