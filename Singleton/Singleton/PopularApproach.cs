using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
  
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
}
