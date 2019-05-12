using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class WrongApproach : Employee
    {
        // NOTE: This won't let derived class to create any instance with new keyword if the this class is not sealed.
        private WrongApproach()
        {
        }
        
        private static Employee _instance;
        public static Employee Instance
        {
            get
            {
                _instance = new Employee();
                return _instance;
            }
        }
    }
}
