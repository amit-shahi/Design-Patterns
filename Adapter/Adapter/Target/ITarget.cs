using Adapter.ThirdPartyEmployee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Target
{
    public interface ITarget
    {
        List<Employee> GetEmployees();

    }
}
