using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.DependencyInjection
{
    public class EmployeeBusinessLogic
    {
        private IEmployeeDataAccess _dataAccess;

        public EmployeeBusinessLogic()
        {
        }

        public EmployeeBusinessLogic(IEmployeeDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IEmployeeDataAccess EmployeeDataAccess { get;  set; }

        public List<Employee> GetEmployees()
        {
            return _dataAccess.GetEmployees();
        }


        //method injeciton
        public List<Employee> GetEmployees(IEmployeeDataAccess employeeDataAccess)
        {
            _dataAccess = employeeDataAccess;

            return _dataAccess.GetEmployees();
        }
    }
}
