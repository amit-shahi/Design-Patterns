
using Adapter.Target;
using Adapter.ThirdPartyEmployee;
using System;
using static System.Console;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Adapter Pattern Example");
            WriteLine("-----------------------");

            // DO NOT USE THIS WAY, INSTEAD CREATE AN ADAPTER CLASS
            //ThirdPartyEmployeeClass employeeClass = new ThirdPartyEmployeeClass();
            // NOTE:
            // Instead of using ThirdParty class directly into our main program
            // We use ITarget interface method which calls ThirdParty GetEmployeesFromThirdParty() via Adapter Class



            ITarget adapter = new Adapter();

            foreach(var employee in adapter.GetEmployees())
            {
                WriteLine($"{employee.Id} - {employee.Name} - joined {employee.Department.ToString()} Department on {employee.JoinDate.ToShortDateString()}");
            }

        }
    }
}
