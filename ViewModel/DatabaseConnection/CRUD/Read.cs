using CIMS.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

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
                string read = SqliteQuery.Read("Employee");
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
                string read = SqliteQuery.Read("User");
                var output = cnn.Query<User>(read, new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
