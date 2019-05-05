using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class WrongApproach : Employee
    {
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
