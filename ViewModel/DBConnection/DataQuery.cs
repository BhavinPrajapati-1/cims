using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.ViewModel.DBConnection
{
    public class DataQuery
    {
        private DatabaseController dbConnect = new DatabaseController();

        #region DynamicQueries
        private DataTable SelectAllFromView(string viewName)
        {
            try
            {
                string query = "SELECT * FROM " + viewName;
                return dbConnect.ExecuteDataReader(query);
            }
            catch
            {
                return null;
            }
        }
        private DataTable SelectIdAndNameFromTable(string tableName)
        {
            try
            {
                string query = "SELECT ID, Name FROM " + tableName +
                        " WHERE DeleteFlag='N'";
                return dbConnect.ExecuteDataReader(query);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region SelectDataTables
        public DataTable UserTable()
        {
            return SelectAllFromView("User_View");
        }
        public DataTable EmployeeTable()
        {
            return SelectAllFromView("Employee_View");
        }
        public DataTable UnitTable()
        {
            return SelectAllFromView("Unit_View");
        }
        public DataTable UnitProgressTable()
        {
            return SelectAllFromView("UnitProgress_View");
        }
        #endregion

        #region SelectDropDownValues
        public DataTable UserAccessType()
        {
            return SelectIdAndNameFromTable("AccessType");
        }
        public DataTable EmployeePosition()
        {
            return SelectIdAndNameFromTable("Position");
        }

        public DataTable UnitStatus()
        {
            return SelectIdAndNameFromTable("UnitStatus");
        }
        public DataTable UnitType()
        {
            return SelectIdAndNameFromTable("UnitType");
        }
        #endregion

        #region SelectWithParameters
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

        #endregion

        #region Save

        public string InsertIntoTable(object objectProperty, string tableName)
        {
            string insert = "INSERT INTO " + tableName +  FieldName(objectProperty);
            string values = "VALUES(" + FieldValue(objectProperty) + ")";
            string query = insert + " " + values;
            try
            {
                dbConnect.ExecuteNonQuery(query);
                return "Data successfully saved!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Updatetable(object objectProperty, string tableName, int id)
        {
            string update = "UPDATE " + tableName ;
            string set = "SET " + FieldValue(objectProperty);
            string where = "WHERE ID = " + id;
            string query = update + " " + set + " " + where;
            try
            {
                dbConnect.ExecuteNonQuery(query);
                return "Data successfully saved!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


        #endregion


        private string FieldName(object classProperty)
        {
            string fields = "(";
            foreach (var property in classProperty.GetType().GetProperties())
                fields = property.Name.ToString() + ",";
            fields = fields.Substring(0, fields.Length - 1);
            return fields + ")";
        }

        private string FieldValue(object classProperty)
        {
            string fields = "(";
            foreach (var property in classProperty.GetType().GetProperties())
                fields = property.GetValue(property, null).ToString() + ",";
            fields = fields.Substring(0, fields.Length - 1);
            return fields + ")";
        }

        private string FieldSet(object classProperty)
        {
            string fields = "(";
            foreach (var property in classProperty.GetType().GetProperties())
                fields = property.Name.ToString() + " = " + property.GetValue(property, null).ToString() + ",";
            fields = fields.Substring(0, fields.Length - 1);
            return fields + ")";
        }
    }
}
