using CIMS.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;

namespace CIMS.ViewModels.DatabaseConnection.CRUD
{
    public class Read
    {
        public static List<string> Dropdown(string tableName, [Optional]string where)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string whereQuery = where == null ? "" : " where " + where;
                string read = "select Name from " + tableName + whereQuery;
                var output = cnn.Query<string>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<EmployeeModel> Employees()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewEmployee");
                var output = cnn.Query<EmployeeModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<SupplierModel> Suppliers()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("Supplier");
                var output = cnn.Query<SupplierModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<UserModel> Users()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewUser");
                var output = cnn.Query<UserModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<DatabaseModel> Database()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewDatabase");
                var output = cnn.Query<DatabaseModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<InventoryModel> Inventory()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewInventory");
                var output = cnn.Query<InventoryModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<UnitModel> Units()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewUnit");
                var output = cnn.Query<UnitModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<UnitProgressModel> UnitProgress()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewUnitProgress");
                var output = cnn.Query<UnitProgressModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Transaction> Transactions()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewTransaction");
                var output = cnn.Query<Transaction>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<ReportModel> Reports()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewReports");
                var output = cnn.Query<ReportModel>(read, new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
