using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    class Employee
    {
        private int empNum;
        private String jobTitle;
        private String name;
        private String email;
        private String phoneNum;
        private String dept;
        

        public Employee(int empNum, string jobTitle, string name, string email, string phoneNum, string dept)
        {
            this.empNum = empNum;
            this.jobTitle = jobTitle;
            this.name = name;
            this.email = email;
            this.phoneNum = phoneNum;
            this.dept = dept;
        }


        public void PrintDetails()
        {
            Console.WriteLine("Employee Number:" +empNum);
            Console.WriteLine("Job Title: " + jobTitle);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone Number: " + phoneNum);
            Console.WriteLine("Department: " + dept);
        }


    }
}
