using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.CreationalDesignPatterns.FactoryDesignPattern
{
    public class PartTimePayroll : IPayroll
    {
        public PayRollType PayRollType => PayRollType.PartTime;

        public decimal GetBonus()
        {
            return 20;
        }

        public decimal GetSalary()
        {
            return 150;
        }
    }
}
