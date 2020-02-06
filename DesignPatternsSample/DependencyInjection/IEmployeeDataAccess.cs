﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.DependencyInjection
{
    public interface IEmployeeDataAccess
    {
        List<Employee> GetEmployees();
    }
}
