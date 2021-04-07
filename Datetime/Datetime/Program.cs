using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current Time&Date: {DateTime.Now}");
            Console.WriteLine("Type a Number Below to see what it will be hours from now!");
            int xHours = Convert.ToInt32(Console.ReadLine());
            DateTime current = DateTime.Now;
            DateTime future = current.AddHours(xHours);
            Console.WriteLine(future);

            Console.ReadLine();

        }
    }
}
