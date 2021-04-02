using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 1;
            Employee employee1 = new Employee();
            employee1.FirstName = "Student";
            employee1.LastName = "Sample";
            employee1.ID = 2;
            employee.SayName();
            employee1.SayName();
            Console.WriteLine("ID Match?");
            Console.WriteLine(employee == employee1);
            Console.ReadLine();
        }
    }
}
