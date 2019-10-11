
namespace CIMS.Model
{
    public class BillOfMaterials
    {
        public int ID { get; set; }
        public int Unit_ID { get; set; }
        public int Inventory_ID { get; set; }
        public int Quantity { get; set; }
        public string Headers
        {
            get
            {
                return "Unit_ID,Inventory_ID,Quantity,";
            }
        }
    }
}
