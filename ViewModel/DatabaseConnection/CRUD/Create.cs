using CIMS.Model;
using System.Collections.Generic;
using System.Linq;

namespace CIMS.ViewModel.DatabaseConnection.CRUD
{
    public class Create
    {

        public static void BillOfMaterials(BillOfMaterials table)
        {
            string insert = SqliteQuery.Create("BillOfMaterials", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Database(Database table)
        {
            string insert = SqliteQuery.Create("Database", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Employee(Employee table)
        {
            string insert = SqliteQuery.Create("Employee", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Inventory(Inventory table)
        {
            string insert = SqliteQuery.Create("Inventory", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void InventoryLimit(InventoryLimit table)
        {
            string insert = SqliteQuery.Create("InventoryLimit", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Supplier(Supplier table)
        {
            string insert = SqliteQuery.Create("Supplier", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Transaction(Transaction table)
        {
            string insert = SqliteQuery.Create("Transaction", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Unit(Unit table)
        {
            string insert = SqliteQuery.Create("Unit", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void UnitProgress(UnitProgress table)
        {
            string insert = SqliteQuery.Create("UnitProgress", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void User(User table)
        {
            string insert = SqliteQuery.Create("User", table.Headers);
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
        public static void Dropdown(Dropdown table)
        {
            List<string> list = Read.Dropdown(table.NameOfTable, "Name=" + table.Name);
            if (list != null) return;
            string insert = SqliteQuery.Create(table.NameOfTable, "Name");
            SqliteDataAccess.ExecuteQuery(insert, table);
        }
    }
}
