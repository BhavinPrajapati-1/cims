using CIMS.Models;

namespace CIMS.ViewModels.DatabaseConnection.CRUD
{
    public class Delete
    {
        public static void BillOfMaterials(BillOfMaterialsModel table)
        {
            string Delete = SqliteQuery.Delete("BillOfMaterials", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Database(DatabaseModel table)
        {
            string Delete = SqliteQuery.Delete("Database", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Employee(EmployeeModel table)
        {
            string Delete = SqliteQuery.Delete("Employee", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Inventory(InventoryModel table)
        {
            string Delete = SqliteQuery.Delete("Inventory", table.ItemCode);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void InventoryLimit(InventoryLimitModel table)
        {
            string Delete = SqliteQuery.Delete("InventoryLimit", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Supplier(SupplierModel table)
        {
            string Delete = SqliteQuery.Delete("Supplier", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Transaction(Transaction table)
        {
            string Delete = SqliteQuery.Delete("Transaction", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void Unit(UnitModel table)
        {
            string Delete = SqliteQuery.Delete("Unit", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void UnitProgress(UnitProgressModel table)
        {
            string Delete = SqliteQuery.Delete("UnitProgress", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
        public static void User(UserModel table)
        {
            string Delete = SqliteQuery.Delete("User", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }

        public static void Dropdown(DropdownModel table)
        {
            string Delete = SqliteQuery.Delete("Dropdown", table.ID);
            SqliteDataAccess.ExecuteQuery(Delete, table);
        }
    }
}
