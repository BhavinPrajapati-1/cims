using CIMS.Model;

namespace CIMS.ViewModel.DatabaseConnection.CRUD
{
    public class Delete
    {
        public static void BillOfMaterials(BillOfMaterials table)
        {
            string Delete = SqliteQuery.Delete("BillOfMaterials", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Database(Database table)
        {
            string Delete = SqliteQuery.Delete("Database", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Employee(Employee table)
        {
            string Delete = SqliteQuery.Delete("Employee", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Inventory(Inventory table)
        {
            string Delete = SqliteQuery.Delete("Inventory", table.ItemCode);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void InventoryLimit(InventoryLimit table)
        {
            string Delete = SqliteQuery.Delete("InventoryLimit", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Supplier(Supplier table)
        {
            string Delete = SqliteQuery.Delete("Supplier", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Transaction(Transaction table)
        {
            string Delete = SqliteQuery.Delete("Transaction", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Unit(Unit table)
        {
            string Delete = SqliteQuery.Delete("Unit", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void UnitProgress(UnitProgress table)
        {
            string Delete = SqliteQuery.Delete("UnitProgress", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void User(User table)
        {
            string Delete = SqliteQuery.Delete("User", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }

        public static void Dropdown(Dropdown table)
        {
            string Delete = SqliteQuery.Delete("Dropdown", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
    }
}
