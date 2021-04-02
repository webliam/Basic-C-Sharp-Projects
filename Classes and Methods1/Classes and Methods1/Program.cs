using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            decimal b = 9.9m;
            string c = "13";
            int total;
            MathOperation n = new MathOperation();
            total = n.Sum(a);
            Console.WriteLine("The sum of " + a + " and " + "25" + " is " + total);
            total = n.Difference(b);
            Console.WriteLine("The difference of " + b + " and " + "8" + " is " + total);
            total = n.Product(c);
            Console.WriteLine("The product of " + c + " and " + "10" + " is " + total);
            Console.ReadLine();
        }
    }
}
