using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
  
    public class QuickApproach : Employee
    {
        // NOTE:
        // CLR handles lock() functionality for us.

        private static readonly Employee _instance = new Employee();

        public static Employee Instance
        {
            get
            {
                return _instance;
            }
        }
    }

    public class PopularApproach : Employee
    {
        // NOTE:
        // To Make it Thread Safe for Multi Threaded Enviroment
        // We use lock()

        private static readonly object _lock = new object();

        private static Employee _instance;
        public static Employee Instance
        {
            get
            {
                lock (_lock)
                {
                    // NOTE:
                    // Two threads can hit if statement at the same time, and we will end up having multiple instances created. 
                    // To make it thread safe, we use lock as shown above

                    if (_instance == null)
                    {
                        _instance = new Employee();
                    }
                    return _instance;
                }
            }

        }
    }

    public class WrongApproach : Employee
    {
        private static Employee _instance;
        public static Employee Instance
        {
            get
            {
                _instance =  new Employee();
                return _instance;
            }
        }
    }

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
