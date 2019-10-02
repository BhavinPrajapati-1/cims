using CIMS.Model;
using CIMS.ViewModel.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.ViewModel
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set;  }

        public EmployeeViewModel()
        {
            DataQuery dataQuery = new DataQuery();
            DataTable dataTable = dataQuery.EmployeeTable();
            //employees= dataTable.to
        }
    }
}
