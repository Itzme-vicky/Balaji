using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; } = string.Empty;
        public string CompanyLocation { get; set; } = string.Empty;

        public Company(int companyId, string companyName, string companyLocation)
        {
            CompanyId = companyId; 
            CompanyName = companyName;
            CompanyLocation = companyLocation;
        }

        //public Company()
        //{

        //}

        //public Company(int Id, string Name)
        //{
        //    this.Id = Id; ;
        //    this.Name = Name;

        //}


     
        public void CompanyInfo()
        {
            Console.WriteLine($"Company ID: {CompanyId}, Company Name: {CompanyName} , Company Location: {CompanyLocation}");
          
        }
    }
}
