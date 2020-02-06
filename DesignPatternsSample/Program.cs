using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For Dependency Injections
using DesignPatternsSample.DependencyInjection;


//For Factory Design Pattern
using DesignPatternsSample.CreationalDesignPatterns.FactoryDesignPattern;


namespace DesignPatternsSample
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dependency Injections
            ////constructor  dependency injection
            //EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic(new EmployeeDataAccess());

            //var employees = employeeBusinessLogic.GetEmployees();
            //employees.ForEach(x => Console.WriteLine(x.FullName));
            //Console.WriteLine("---------");

            ////properties dependency injection
            //employeeBusinessLogic.EmployeeDataAccess = new EmployeeDataAccess();
            //var employeeList = employeeBusinessLogic.EmployeeDataAccess.GetEmployees();
            //employeeList.ForEach(x => Console.WriteLine(x.FullName));
            //Console.WriteLine("---------");

            ////method injection
            //EmployeeBusinessLogic businessLogic = new EmployeeBusinessLogic();
            //var _employeeList = businessLogic.GetEmployees(new EmployeeDataAccess());
            //_employeeList.ForEach(x => Console.WriteLine(x.FullName));
            #endregion


            #region FactoryPattern
            Console.WriteLine("FactoryPattern \n***********");

            var getProbationPayroll = FactoryPayroll.GetPayroll(PayRollType.Probation);
            Console.WriteLine("Probation Payroll");
            Console.WriteLine($"Salary : {getProbationPayroll.GetSalary()}; Bonus : {getProbationPayroll.GetBonus()}");
            Console.WriteLine("-----------------");


            var getPermanentPayroll = FactoryPayroll.GetPayroll(PayRollType.Permanent);
            Console.WriteLine("Permanent Payroll");
            Console.WriteLine($"Salary : {getPermanentPayroll.GetSalary()}; Bonus : {getPermanentPayroll.GetBonus()}");
            Console.WriteLine("-----------------");

            var getPartTimePayroll = FactoryPayroll.GetPayroll(PayRollType.PartTime);
            Console.WriteLine("PartTime Payroll");
            Console.WriteLine($"Salary : {getPartTimePayroll.GetSalary()}; Bonus : {getPartTimePayroll.GetBonus()}");
            Console.WriteLine("-----------------");

            #endregion
            Console.ReadLine();
        }
    }
}
