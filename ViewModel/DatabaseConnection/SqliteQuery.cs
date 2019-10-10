using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.ViewModel.DatabaseConnection
{
    public class SqliteQuery
    {
        public static string Create(string tableName, string headers)
        {
            string values = "values(@" + headers.Replace(",", ",@") + ")";
            headers = "(" + headers + ") ";
            return "insert into " + tableName + headers + values;
        }

        public static string Read(string tableName)
        {
            return "select * from " + tableName;
        }
        public static string Update(string tableName, string headers, int id)
        {
            string set = "";
            string[] values = headers.Split(',');
            foreach (var value in values) {
                set = set + value + " = @" + value + ", ";
            }
            set = " set " + set.Substring(0, set.Length - 2);
            return "update " + tableName + set + " where ID = " + id;
        }
        public static string Delete(string tableName, int id)
        {
            return "delete from " + tableName + " where ID = " + id;
        }
    }

}
