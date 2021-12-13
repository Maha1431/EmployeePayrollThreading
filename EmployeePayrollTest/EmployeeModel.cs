using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollTest
{
   public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public EmployeeModel(int employeeID, string employeeName, string phoneNumber, string address,
            string department, char gender, double basicPay, double deductions, double taxablePay,
            double tax, double netPay, string city, string country)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Department = department;
            this.Gender = gender;
            this.BasicPay = basicPay;
            this.Deductions = deductions;
            this.TaxablePay = taxablePay;
            this.Tax = tax;
            this.NetPay = netPay;
            this.City = city;
            this.Country = country;
        }

        
    }
}
