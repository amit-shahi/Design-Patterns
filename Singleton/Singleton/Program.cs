using System;
using static System.Console;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Singleton Example of Creational Design Pattern");
            WriteLine("----------------------------------------------");
            WriteLine();


            // Get a Single Instance of an Employee Object Using Popular/ Old School Approach
            var instanceOfEmpolyeePopular = PopularApproach.Instance.GetEmployeeName();

            WriteLine($"Single Instance of Employee {instanceOfEmpolyeePopular} is created using Popular Singleton Approach.");

            WriteLine();


            // Get a Single Instance of an Employee Object Using Quick Approach
            var instanceOfEmployeeQuick = QuickApproach.Instance.GetEmployeeName();

            WriteLine($"Single Instance of Employee {instanceOfEmployeeQuick} is created using Quick Singleton Approach.");

            // Get a Single Instance of an Employee Object using Lazy Approach

            var instanceOfEmployeeLazy = LazyApproach.Instance.GetEmployeeName();
            
            WriteLine($"Single Instance of Employee {instanceOfEmployeeLazy} is created using Lazy Singleton Approach.");
            // NOTE;
            // Make sure to run SingleInstance.UnitTest to see the difference between all three approach.

        }
    }
}
