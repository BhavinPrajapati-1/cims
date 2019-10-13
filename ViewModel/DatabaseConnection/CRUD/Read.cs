using CIMS.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;

namespace CIMS.ViewModel.DatabaseConnection.CRUD
{
    public class Read
    {

        public static List<string> DropdownValue(string tableName)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = "select Name from " + tableName;
                var output = cnn.Query<string>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Employee> Employees()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewEmployee");
                var output = cnn.Query<Employee>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Supplier> Suppliers()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("Supplier");
                var output = cnn.Query<Supplier>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<User> Users()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewUser");
                var output = cnn.Query<User>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Database> Database()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewDatabase");
                var output = cnn.Query<Database>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Inventory> Inventory()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewInventory");
                var output = cnn.Query<Inventory>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Unit> Units()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewUnit");
                var output = cnn.Query<Unit>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<UnitProgress> UnitProgress()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewUnitProgress");
                var output = cnn.Query<UnitProgress>(read, new DynamicParameters());
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
        public static List<Report> Reports()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string read = SqliteQuery.Read("ViewReports");
                var output = cnn.Query<Report>(read, new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
