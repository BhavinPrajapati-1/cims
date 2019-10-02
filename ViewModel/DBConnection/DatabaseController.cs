using System;
using System.Data;
using System.Data.SQLite;

namespace CIMS.ViewModel.DBConnection
{
    public class DatabaseController
    {
        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private DataTable dataReader;

        public void ExecuteNonQuery(string insertQuery)
        {
            try
            {
                ConnectToDB(insertQuery);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void ConnectToDB(string sqlQuery)
        {
            sqlConnection = new SQLiteConnection(DatabasePath());
            sqlCommand = new SQLiteCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
        }

        private string DatabasePath()
        {
            return @"Data Source = " + Environment.CurrentDirectory + @"\CIMS.db";
        }

        public int ExecuteSclarInt(string selectQuery)
        {
            object result = ExecuteScalarResult(selectQuery);
            return int.Parse((result == null ? "0" : result.ToString()));
        }

        private object ExecuteScalarResult(string selectQuery)
        {
            try
            {
                ConnectToDB(selectQuery);
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataTable ExecuteDataReader(string query)
        {
            try
            {
                ConnectToDB(query);
                LoadDataReader();
                return dataReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void LoadDataReader()
        {
            dataReader = new DataTable();
            dataReader.Load(sqlCommand.ExecuteReader());
        }
    }
}
