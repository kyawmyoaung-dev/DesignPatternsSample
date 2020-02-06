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
        public EmployeeBusinessLogic(IEmployeeDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Employee> GetEmployees()
        {
            return _dataAccess.GetEmployees();
        }
    }
}
