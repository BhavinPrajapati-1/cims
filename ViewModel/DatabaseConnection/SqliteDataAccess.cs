using CIMS.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;
using System;

namespace CIMS.ViewModel.DatabaseConnection
{
    public class SqliteDataAccess
    {
        #region Create
        public static void InsertEmployee(Employee employee)
        {
            string insert = SqliteQuery.Create("Employee", employee.Headers);
            ExecuteQuery(insert, employee);
        }
        public static void InsertUser(User user)
        {
            string insert = SqliteQuery.Create("User", user.Headers);
            ExecuteQuery(insert, user);
        }
        public static void InsertSupplier(Supplier supplier)
        {
            string insert = SqliteQuery.Create("Supplier", supplier.Headers);
            ExecuteQuery(insert, supplier);
        }
        #endregion

        #region Read
        public static List<Employee> LoadEmployees()
        { 
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string read = SqliteQuery.Read("Employee");
                var output = cnn.Query<Employee>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Supplier> LoadSupplier()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string read = SqliteQuery.Read("Supplier");
                var output = cnn.Query<Supplier>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<User> LoadUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string read = SqliteQuery.Read("User");
                var output = cnn.Query<User>(read, new DynamicParameters());
                return output.ToList();
            }
        }
        #endregion


        #region Update
        public static void UpdateEmployee(Employee employee)
        {
            string update = SqliteQuery.Update("Employee", employee.Headers, employee.ID);
            ExecuteQuery(update, employee);
        }
        public static void UpdateUser(User user)
        {
            string update = SqliteQuery.Update("User", user.Headers, user.ID);
            ExecuteQuery(update, user);
        }
        public static void UpdateSupplier(Supplier supplier)
        {
            string update = SqliteQuery.Update("Supplier", supplier.Headers, supplier.ID);
            ExecuteQuery(update, supplier);
        }
        #endregion


        #region Delete
        public static void DeleteEmployee(Employee employee)
        {
            string Delete = SqliteQuery.Delete("Employee", employee.ID);
            ExecuteQuery(Delete, employee);
        }
        public static void DeleteUser(User user)
        {
            string Delete = SqliteQuery.Delete("User", user.ID);
            ExecuteQuery(Delete, user);
        }
        public static void DeleteSupplier(Supplier supplier)
        {
            string Delete = SqliteQuery.Delete("Supplier", supplier.ID);
            ExecuteQuery(Delete, supplier);
        }

        #endregion

        private static void ExecuteQuery<T>(string textQuery, T tableModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(textQuery, tableModel);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
