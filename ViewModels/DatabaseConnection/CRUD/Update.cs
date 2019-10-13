using CIMS.Models;

namespace CIMS.ViewModels.DatabaseConnection.CRUD
{
    public class Update
    {
        public static void BillOfMaterials(BillOfMaterialsModel table)
        {
            string update = SqliteQuery.Update("BillOfMaterials", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Database(DatabaseModel table)
        {
            string update = SqliteQuery.Update("Database", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Employee(EmployeeModel table)
        {
            string update = SqliteQuery.Update("Employee", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Inventory(InventoryModel table)
        {
            string update = SqliteQuery.Update("Inventory", table.Headers, table.ItemCode);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void InventoryLimit(InventoryLimitModel table)
        {
            string update = SqliteQuery.Update("InventoryLimit", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Supplier(SupplierModel table)
        {
            string update = SqliteQuery.Update("Supplier", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Transaction(Transaction table)
        {
            string update = SqliteQuery.Update("Transaction", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Unit(UnitModel table)
        {
            string update = SqliteQuery.Update("Unit", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void UnitProgress(UnitProgressModel table)
        {
            string update = SqliteQuery.Update("UnitProgress", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void User(UserModel table)
        {
            string update = SqliteQuery.Update("User", table.Headers, table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
        public static void Dropdown(DropdownModel table)
        {
            string update = SqliteQuery.Update("Dropdown", "Name", table.ID);
            SqliteDataAccess.ExecuteQuery(update, table);
        }
    }
}
