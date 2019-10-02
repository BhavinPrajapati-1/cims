using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.ViewModel.DBConnection
{
    public class DataQuery
    {
        private DatabaseController dbConnect = new DatabaseController();

        public DataTable UserTable()
        {
            try
            {
                string query = "SELECT * FROM User_View";
                return dbConnect.ExecuteDataReader(query);
            }
            catch
            {
                return null;
            }
        }
        public DataTable EmployeeTable()
        {
            try
            {
                string query = "SELECT * FROM User_View";
                return dbConnect.ExecuteDataReader(query);
            }
            catch
            {
                return null;
            }
        }

    }
}
