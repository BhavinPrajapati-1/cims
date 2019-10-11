using CIMS.Model;

namespace CIMS.ViewModel.DatabaseConnection.CRUD
{
    public class Create
    {
        public static void Employee(Employee employee)
        {
            string insert = SqliteQuery.Create("Employee", employee.Headers);
            SqliteDataAccess.ExecuteQuery(insert, employee);
        }
        public static void User(User user)
        {
            string insert = SqliteQuery.Create("User", user.Headers);
            SqliteDataAccess.ExecuteQuery(insert, user);
        }
        public static void Supplier(Supplier supplier)
        {
            string insert = SqliteQuery.Create("Supplier", supplier.Headers);
            SqliteDataAccess.ExecuteQuery(insert, supplier);
        }
    }
}
