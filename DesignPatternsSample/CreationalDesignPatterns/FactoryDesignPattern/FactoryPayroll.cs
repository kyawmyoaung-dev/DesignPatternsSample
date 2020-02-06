using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.CreationalDesignPatterns.FactoryDesignPattern
{
    public class FactoryPayroll
    {
        public static IPayroll GetPayroll(PayRollType payRollType)
        {
            IPayroll payroll = null;

            switch (payRollType)
            {
                case PayRollType.Probation:
                    payroll = new ProbationPayroll();
                    break;
                case PayRollType.Permanent:
                    payroll = new PermanentPayroll();
                    break;
                case PayRollType.PartTime:
                    payroll = new PartTimePayroll();
                    break;
            }

            return payroll;
        }
    }
}
