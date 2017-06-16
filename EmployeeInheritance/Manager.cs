using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    class Manager : Employee
    {
        private string secName;
        public void PrintSecName()
        {
            Console.WriteLine("Secretary Name: " + secName);
        }

        public Manager(int empNum, string jobTitle, string name, string email, string phoneNum, string dept, string secName) 
            : base(empNum, jobTitle, name, email, phoneNum, dept)
        {
            this.secName = secName;
        }

        public void PrintDetails()
        {
            base.PrintDetails();
            PrintSecName();
        }

    }
}
