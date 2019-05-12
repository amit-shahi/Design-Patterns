using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{

    public sealed class QuickApproach : Employee
    {
        // NOTE: This won't let derived class to create any instance with new keyword if the this class is not sealed.
        private QuickApproach()
        {
        }
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
}
