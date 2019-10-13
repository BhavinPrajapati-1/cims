using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models
{
    public class InventoryModel
    {
        public string ItemCode { get; set; }
        public int Class1_ID { get; set; }
        public int Class1Name { get; set; }
        public int Class2_ID { get; set; }
        public int Class2Name { get; set; }
        public int QuantityType_ID { get; set; }
        public int QuantityTypeName { get; set; }
        public int Barcode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public string Headers
        {
            get
            {
                return "ItemCode,Class1_ID,Class2_ID,QuantityType_ID,Barcode,Description,Quantity";
            }
        }
    }
}
