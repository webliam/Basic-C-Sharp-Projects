using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer \"True\" or \"False\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            //qualified
            Console.WriteLine("Are you qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);
            Console.Read();
        }
    }
}
