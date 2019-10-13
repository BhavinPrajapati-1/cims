using CIMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace CIMS.ViewModels.DatabaseConnection.CRUD
{
    public class Create
    {

        public static void BillOfMaterials(BillOfMaterialsModel table)
        {
            string insert = SqliteQuery.Create("BillOfMaterials", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Database(DatabaseModel table)
        {
            string insert = SqliteQuery.Create("Database", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Employee(EmployeeModel table)
        {
            string insert = SqliteQuery.Create("Employee", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Inventory(InventoryModel table)
        {
            string insert = SqliteQuery.Create("Inventory", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void InventoryLimit(InventoryLimitModel table)
        {
            string insert = SqliteQuery.Create("InventoryLimit", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Supplier(SupplierModel table)
        {
            string insert = SqliteQuery.Create("Supplier", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Transaction(Transaction table)
        {
            string insert = SqliteQuery.Create("Transaction", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Unit(UnitModel table)
        {
            string insert = SqliteQuery.Create("Unit", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void UnitProgress(UnitProgressModel table)
        {
            string insert = SqliteQuery.Create("UnitProgress", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void User(UserModel table)
        {
            string insert = SqliteQuery.Create("User", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Dropdown(DropdownModel table)
        {
            List<string> list = Read.Dropdown(table.NameOfTable, "Name=" + table.Name);
            if (list != null) return;
            string insert = SqliteQuery.Create(table.NameOfTable, "Name");
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
    }
}
