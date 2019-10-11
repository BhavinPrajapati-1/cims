using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace CIMS.ViewModel.DatabaseConnection
{
    public class SqliteDataAccess
    {
        public static void ExecuteQuery<T>(string textQuery, T tableModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(textQuery, tableModel);
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
