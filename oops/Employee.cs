using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    public class Employee :Company
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EmployeeLocation { get; set; } = string.Empty;

        public Employee(int employeeId, string employeeName, string employeeLocation , int companyId, string companyName, string companyLocation):base (companyId, companyName, companyLocation)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeLocation = employeeLocation;
        }

        public void EmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}, Employee Name: {EmployeeName} , Employee Location: {EmployeeLocation}");
        }
    }
}
