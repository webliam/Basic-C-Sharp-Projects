using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath moreMath = new SimpleMath();
            Console.WriteLine("Please enter a number you want to add 10 to.");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Now enter a number you want to be displayed.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is:");
            moreMath.returnMultiple(mathNum: x, displayNum: y);

            Console.WriteLine("Min of x and y:");
            Console.WriteLine(Math.Min(x, y));
            if (x<y)
              {
                Console.WriteLine("x is smaller than y");

              }
            else 
                {
                Console.WriteLine("x is greater than y");

                }
            Console.ReadLine();

        }
 

    }
}
