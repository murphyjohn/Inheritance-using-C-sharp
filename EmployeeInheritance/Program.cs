using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Dave = new Employee(1, "Programmer", "Dave Joyce", "bigdavejoyce@bigdave.edu", "0878854782", "Software Dept.");
            Dave.PrintDetails();
            Console.WriteLine("");

            Manager Mike = new Manager(0, "Manager", "Mike Man", "miketheman@managers.com", "0879546788", "HR Dept.", "Jimmy O'Secretary");
            Mike.PrintDetails();
        }
    }
}
