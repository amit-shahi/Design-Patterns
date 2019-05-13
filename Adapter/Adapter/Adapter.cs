using Adapter.Target;
using Adapter.ThirdPartyEmployee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    // NOTE: Adapter Class for Employee
    public class Adapter : ThirdPartyEmployeeClass, ITarget
    {
        public List<Employee> GetEmployees()
        {
            return GetEmployeesFromThirdParty();
        }
    }
}
