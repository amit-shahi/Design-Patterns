using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.ThirdPartyEmployee
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Department Department { get; private set; }
        public DateTime JoinDate { get; private set; }

        public Employee(int id, string name, Department department, DateTime joindate)
        {
            Id = id;
            Name = name;
            Department = department;
            JoinDate = joindate;
        }
    }

    public enum Department
    {
        HR,
        IT,
        SOFT,
        BPO
    }

    // Adaptee Class
    public  class ThirdPartyEmployeeClass
    {

        public List<Employee> GetEmployeesFromThirdParty()
        {

             List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Ram Kumar", Department.HR, DateTime.Parse("01/05/2006")));
            employees.Add(new Employee(2, "Suresh Singh", Department.BPO, DateTime.Parse("07/05/2006")));
            employees.Add(new Employee(3, "Jay Shetty", Department.SOFT, DateTime.Parse("01/08/2006")));
            employees.Add(new Employee(4, "Narendra Sahu", Department.IT, DateTime.Parse("04/09/2006")));
            return employees;
        }
        
    }
}
