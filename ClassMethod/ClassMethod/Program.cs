using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("please give me a number");
            int input = Convert.ToInt32(Console.ReadLine());
            Method.Divide(input);
        }
    }
}
