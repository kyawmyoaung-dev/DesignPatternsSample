using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.CreationalDesignPatterns.FactoryDesignPattern
{
    public class PermanentPayroll : IPayroll
    {
        public PayRollType PayRollType =>  PayRollType.Permanent;

        public decimal GetBonus()
        {
            return 50;
        }

        public decimal GetSalary()
        {
            return 200;
        }
    }
}
