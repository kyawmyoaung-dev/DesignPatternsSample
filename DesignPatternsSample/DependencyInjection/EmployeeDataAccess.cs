using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.DependencyInjection
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { FullName = "Mg Mg", EmailAddress = "mgm@gmail.com", Adddress = "Yangon", PhoneNumber = "0123456" });
            employees.Add(new Employee() { FullName = "Hla Hla", EmailAddress = "halhla@gmail.com", Adddress = "Mandalay", PhoneNumber = "789456" });
            employees.Add(new Employee() { FullName = "Zaw Zaw", EmailAddress = "zaw@gmail.com", Adddress = "Mandalay", PhoneNumber = "654123" });
            employees.Add(new Employee() { FullName = "Aung Aung", EmailAddress = "aung@gmail.com", Adddress = "Yangon", PhoneNumber = "789123" });

            return employees;
        }
    }
}
