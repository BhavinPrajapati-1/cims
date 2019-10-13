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
        public string UnitTypeName { get; set; }
        public int Inventory_ItemCode { get; set; }
        public int InventoryClass1_ID { get; set; }
        public int InventoryClass1Name { get; set; }
        public int InventoryClass2_ID { get; set; }
        public int InventoryClass2Name { get; set; }
        public int InventoryQuantityType_ID { get; set; }
        public int InventoryQuantityTypeName { get; set; }
        public int InventoryBarcode { get; set; }
        public string InventoryDescription { get; set; }
        public double MaximumQuantity { get; set; }

        public string Headers
        {
            get
            {
                return "UnitType_ID,Inventory_ItemCode,MaximumQuantity";
            }
        }
    }
}
