using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
  
    public sealed class PopularApproach : Employee
    {
        // NOTE: This won't let derived class to create any instance with new keyword if the this class is not sealed.
        private PopularApproach()
        {
        }
        // NOTE:
        // To Make it Thread Safe for Multi Threaded Enviroment
        // We use lock()

        private static readonly object _lock = new object();

        // NOTE: The volatile keyword fixed the double lock issue

        private static volatile Employee _instance;
        public static Employee Instance
        {
            get
            {
                // NOTE: We do this for Thread-Safety using Double-Check locking

                if (_instance != null)
                    return _instance;

                // NOTE: We can remove this double lock by removing lock(), because it's fixes in C# 6

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
