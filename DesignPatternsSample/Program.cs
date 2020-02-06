using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternsSample.DependencyInjection;


namespace DesignPatternsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor  dependency injection
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic(new EmployeeDataAccess());

            var employees = employeeBusinessLogic.GetEmployees();
            employees.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine("---------");

            //properties dependency injection
            employeeBusinessLogic.EmployeeDataAccess =new EmployeeDataAccess();
            var employeeList = employeeBusinessLogic.EmployeeDataAccess.GetEmployees();
            employeeList.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine("---------");

            //method injection
            EmployeeBusinessLogic businessLogic=new EmployeeBusinessLogic();
            var _employeeList = businessLogic.GetEmployees(new EmployeeDataAccess());
            _employeeList.ForEach(x => Console.WriteLine(x.FullName));
           
           
            Console.ReadLine();
        }
    }
}
