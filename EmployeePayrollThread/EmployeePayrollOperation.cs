using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollThread
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeModel> models = new List<EmployeeModel>();
        //UC1 non thread
        public void addEmployeePayroll(List<EmployeeModel> employeepayrollDataList)
        {
            employeepayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine(" Employee being Added :" + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added:" + employeeData.EmployeeName);
            });
            Console.WriteLine(this.models.ToString());
        }
        public void addEmployeePayroll (EmployeeModel employee)
        {
            models.Add(employee);
        }

    }

    
}
