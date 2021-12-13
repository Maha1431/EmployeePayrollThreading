using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayrollThread;
using System.Collections.Generic;
using System;
using System.Linq;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given5Employee_whenAddedToemployeeModels_ShouldMatchEmployeeEntries()
        {
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            employeeModels.Add(new EmployeeModel(employeeID: 1, employeeName: "Mahil", phoneNumber: "7418923772", address: "Bangalore", department: "IT", gender: 'F', basicPay: 1000, deductions: 200, taxablePay: 250, tax: 200, netPay: 400, city: "xyz", country: "India"));
            employeeModels.Add(new EmployeeModel(employeeID: 2, employeeName: "Maha", phoneNumber: "987877771", address: "chennai", department: "NonIT", gender: 'F', basicPay: 4000, deductions: 300, taxablePay: 130, tax: 200, netPay: 400, city: "xyz", country: "India"));
            employeeModels.Add(new EmployeeModel(employeeID: 3, employeeName: "Mahesh", phoneNumber: "7827676261`", address: "Hydeabad", department: "HR", gender: 'M', basicPay: 2000, deductions: 500, taxablePay: 350, tax: 200, netPay: 400, city: "xyz", country: "India"));
            employeeModels.Add(new EmployeeModel(employeeID: 4, employeeName: "Manju", phoneNumber: "872998181", address: "Pune", department: "HumanResources", gender: 'F', basicPay: 5000, deductions: 200, taxablePay: 150, tax: 200, netPay: 400, city: "xyz", country: "India"));
            employeeModels.Add(new EmployeeModel(employeeID: 5, employeeName: "Mani", phoneNumber: "818787111", address: "Nellur", department: "CI", gender: 'M', basicPay: 3000, deductions: 100, taxablePay: 450, tax: 200, netPay: 400, city: "xyz", country: "India"));

            EmployeePayrollOperation operation = new EmployeePayrollOperation();
            DateTime StartDateTime = DateTime.Now;
            operation.addEmployeePayroll(employeeModels);
            DateTime StopDateTime = DateTime.Now;
            Console.WriteLine("Duration Without Thread ;" + (StopDateTime - StartDateTime));
            
        }
    }
}
