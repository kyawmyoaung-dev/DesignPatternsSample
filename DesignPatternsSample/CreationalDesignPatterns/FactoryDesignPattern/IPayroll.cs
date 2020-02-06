using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.CreationalDesignPatterns.FactoryDesignPattern
{
    public enum PayRollType
    {
        Probation,
        Permanent,
        PartTime
    }

    public interface IPayroll
    {
        decimal GetSalary();

        decimal GetBonus();

        PayRollType PayRollType { get; }
    }
}
