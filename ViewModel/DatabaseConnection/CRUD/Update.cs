using CIMS.Model;

namespace CIMS.ViewModel.DatabaseConnection.CRUD
{
    public class Update
    {
        public static void Employee(Employee employee)
        {
            string update = SqliteQuery.Update("Employee", employee.Headers, employee.ID);
            SqliteDataAccess.ExecuteQuery(update, employee);
        }
        public static void User(User user)
        {
            string update = SqliteQuery.Update("User", user.Headers, user.ID);
            SqliteDataAccess.ExecuteQuery(update, user);
        }
        public static void Supplier(Supplier supplier)
        {
            string update = SqliteQuery.Update("Supplier", supplier.Headers, supplier.ID);
            SqliteDataAccess.ExecuteQuery(update, supplier);
        }

    }
}
