using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Model
{
    public class InventoryLimit
    {
        public int ID { get; set; }
        public int UnitType_ID { get; set; }
        public int Inventory_ID { get; set; }
        public double MaximumQuantity { get; set; }
    }
}
