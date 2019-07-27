using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class LazyApproach : Employee
    {
        // NOTE: This won't let derived class to create any instance with new keyword if the this class is sealed.
        private LazyApproach()
        {
        }
        
        private static Lazy<Employee> _instance = new Lazy<Employee> ( ()=> new Employee() );
        public static Employee Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
