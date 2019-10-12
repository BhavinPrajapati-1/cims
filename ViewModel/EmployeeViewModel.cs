using CIMS.Model;
using CIMS.ViewModel.DBConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.ViewModel
{
    public class EmployeeViewModel : PropertyChangeHandler
    {
        private DataTable _employeeTable;
        private DataTable _positionList;
        private Employee _selectedEmployee;
        
        public EmployeeViewModel()
        {
            //DataQuery dataQuery = new DataQuery();
            //EmployeeTable = dataQuery.EmployeeTable();
            //PositionList = dataQuery.EmployeePosition();
        }

        public DataTable EmployeeTable
        {
            get
            {
                return _employeeTable;
            }
            set
            {
                if (value == _employeeTable) return;
                _employeeTable = value;
                OnPropertyChanged("EmployeeTable");
            }
        }

        public Employee SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                if (value == _selectedEmployee) return;
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public DataTable PositionList
        {
            get
            {
                return _positionList;
            }
            set
            {
                if (value == _positionList) return;
                _positionList = value;
                OnPropertyChanged("PositionList");
            }
        }
        public int PositionID { get; set; }
        
    }
}
