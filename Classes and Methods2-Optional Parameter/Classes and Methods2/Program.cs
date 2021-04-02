using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter two integers for the math operation");
            Console.WriteLine("Please input a First number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you so desire, go ahead and input a second number.");
            string input = Console.ReadLine();
            bool b1 = string.IsNullOrEmpty(input);
            if (b1 == false)
            {
                int num2 = Convert.ToInt32(input);
                Optional.Method(num1, num2);
            }
            else
            {
                Optional.Method(num1);
            }
            Console.ReadLine();
        }
    }
}
