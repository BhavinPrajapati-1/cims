using CIMS.Model;

namespace CIMS.ViewModel.DatabaseConnection.CRUD
{
    public class Update
    {
        public static void BillOfMaterials(BillOfMaterials table)
        {
            string update = SqliteQuery.Update("BillOfMaterials", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Database(Database table)
        {
            string update = SqliteQuery.Update("Database", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Employee(Employee table)
        {
            string update = SqliteQuery.Update("Employee", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Inventory(Inventory table)
        {
            string update = SqliteQuery.Update("Inventory", table.Headers, table.ItemCode);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void InventoryLimit(InventoryLimit table)
        {
            string update = SqliteQuery.Update("InventoryLimit", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Supplier(Supplier table)
        {
            string update = SqliteQuery.Update("Supplier", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Transaction(Transaction table)
        {
            string update = SqliteQuery.Update("Transaction", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Unit(Unit table)
        {
            string update = SqliteQuery.Update("Unit", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void UnitProgress(UnitProgress table)
        {
            string update = SqliteQuery.Update("UnitProgress", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void User(User table)
        {
            string update = SqliteQuery.Update("User", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Dropdown(Dropdown table)
        {
            string update = SqliteQuery.Update("Dropdown", "Name", table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
    }
}
