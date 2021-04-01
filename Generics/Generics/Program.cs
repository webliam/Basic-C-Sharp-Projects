using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        public static void Main()
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("Sara");
            employee.Things.Add("Sam");
            employee.Things.Add("Liam");
            Employee<int> ID = new Employee<int>();
            ID.Things = new List<int>();
            ID.Things.Add(1);
            ID.Things.Add(2);
            ID.Things.Add(3);
            foreach (string x in employee.Things)
            {
                Console.WriteLine("Employee Name : " + x);
            }
            foreach (int y in ID.Things)
            {
                Console.WriteLine("employeeId : "+ y);
            }
            Console.ReadLine();
        }
    }
}
