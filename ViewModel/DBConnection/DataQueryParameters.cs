using System.Data;

namespace CIMS.ViewModel.DBConnection
{

    public class DataQueryParameters
    {
        private DatabaseController dbConnect = new DatabaseController();

        public DataTable CurrentUser(string userID, string password)
        {
            try
            {
                string query = string.Format("SELECT * FROM User_View where UserName = '{0}' and Password = '{1}'", userID, password);
                return dbConnect.ExecuteDataReader(query);
            }
            catch
            {
                return null;
            }
        }
    }
}
