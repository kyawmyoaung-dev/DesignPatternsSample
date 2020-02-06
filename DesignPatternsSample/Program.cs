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
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();

            var employees = employeeBusinessLogic.GetEmployees();

            employees.ForEach(x => Console.WriteLine(x.FullName));

            Console.ReadLine();
        }
    }
}
