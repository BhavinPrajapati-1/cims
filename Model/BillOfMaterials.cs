
namespace CIMS.Model
{
    public class BillOfMaterials
    {
        public int ID { get; set; }
        public int Unit_ID { get; set; }
        public string UnitName { get; set; }
        public string UnitAddress { get; set; }
        public int InventoryLimit_ID { get; set; }
        public int UnitType_ID { get; set; }
        public int UnitTypeName { get; set; }
        public string InventoryItemCode { get; set; }
        public int InventoryClass1_ID { get; set; }
        public int InventoryClass2_ID { get; set; }
        public int InventoryQuantityType_ID { get; set; }
        public string InventoryBarCode { get; set; }
        public string InventoryDescription { get; set; }
        public int InventoryLimitMaximumQuantity { get; set; }
        public int ActualQuantity { get; set; }

        public string Headers
        {
            get 
            {
                return "Unit_ID,InventoryLimit_ID,Quantity,";
            }
        }
    }
}
