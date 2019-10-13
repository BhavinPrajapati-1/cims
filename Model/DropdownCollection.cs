using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CIMS.Model
{
    public class Dropdown
    {
        public List<string> EmployeePosition { get; set; }
        public List<string> InventoryClass1 { get; set; }
        public List<string> InventoryClass2 { get; set; }
        public List<string> InventoryQuantityType { get; set; }
        public List<string> UnitStatus { get; set; }
        public List<string> UnitType { get; set; }
        public List<string> UserAccessType { get; set; }
    }
}
