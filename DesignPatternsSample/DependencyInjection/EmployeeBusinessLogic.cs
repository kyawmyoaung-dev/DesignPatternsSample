using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.DependencyInjection
{
    public class EmployeeBusinessLogic
    {
        private EmployeeDataAccess dataAccess;
        public EmployeeBusinessLogic()
        {
            dataAccess = new EmployeeDataAccess();
        }

        public List<Employee> GetEmployees()
        {
            return dataAccess.GetEmployees();
        }
    }
}
