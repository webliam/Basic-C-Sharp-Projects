using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number(14.5678m);
            num1.PrintAmount();
            Console.ReadLine();
        }
    }
}
