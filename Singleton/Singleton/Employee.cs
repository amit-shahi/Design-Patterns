using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Employee
    {

        public Employee()
        {
        }

        private int Id { get; set; } = 123;
        private string Name { get; set; } = "Amit";

        public string GetEmployeeName() => Name;

    }

}
