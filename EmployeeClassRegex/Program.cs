using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HandlingRegEx
{
    public class EmployeeClass
    {
        public void GetDetails()
        {
            Console.WriteLine("Enter Employee Name : ");
            string EName=Console.ReadLine();
            Regex sal = new Regex("^[0-9]{5,6}$");
            Match ma = sal.Match("100000");
            if (ma.Success)
            {
                Console.WriteLine("The Salary is : " + ma.Value);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Salary");
            }
        }
        
        static void Main(string[] args)
        {
            EmployeeClass e=new EmployeeClass();
            e.GetDetails();
            Regex EId = new Regex("^[A-Z]{3}[0-9]{4}$");
            Match m = EId.Match("EDS2347");
            if (m.Success)
            {

                Console.WriteLine("The Employee Id is : " + m.Value);
            }
            else
            {
                Console.WriteLine("Please Enter Correct Employee Id");
            }
        }
    }
}
