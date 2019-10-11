using CIMS.Model;

namespace CIMS.ViewModel.DatabaseConnection.CRUD
{
    public class Delete
    {
        public static void Employee(Employee employee)
        {
            string Delete = SqliteQuery.Delete("Employee", employee.ID);
            SqliteDataAccess.ExecuteQuery(Delete, employee);
        }
        public static void User(User user)
        {
            string Delete = SqliteQuery.Delete("User", user.ID);
            SqliteDataAccess.ExecuteQuery(Delete, user);
        }
        public static void Supplier(Supplier supplier)
        {
            string Delete = SqliteQuery.Delete("Supplier", supplier.ID);
            SqliteDataAccess.ExecuteQuery(Delete, supplier);
        }
    }
}
