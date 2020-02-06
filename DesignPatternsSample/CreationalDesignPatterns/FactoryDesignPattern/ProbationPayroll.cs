using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.CreationalDesignPatterns.FactoryDesignPattern
{
    public class ProbationPayroll : IPayroll
    {
        public PayRollType PayRollType => PayRollType.Probation;

        public decimal GetBonus()
        {
            return 0;
        }

        public decimal GetSalary()
        {
            return 100;
        }
    }
}
