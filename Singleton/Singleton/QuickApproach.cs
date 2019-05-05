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
}
