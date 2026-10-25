using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
     public class Salary : Employee
    {
        public int salary { get; set; }

        public Salary(int employeeId, string employeeName, string employeeLocation, int companyId, string companyName, string companyLocation ,int salary):base(employeeId, employeeName, employeeLocation, companyId, companyName, companyLocation)
        {
           this.salary = salary;
        }

        public void SalaryInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}, Employee Name: {EmployeeName} , Employee Location: {EmployeeLocation}, Company ID: {CompanyId}, Company Name: {CompanyName}, Company Location: {CompanyLocation}, Salary: {salary}");
        }

    }
}