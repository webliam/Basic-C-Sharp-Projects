﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathapp
{
    class Program
    {
        static void Main()
        {
            //Take input and multiply by 50
            Console.WriteLine("Write any number you want multiplied by 50");
            string userNum0 = Console.ReadLine();
            int multiple = Int32.Parse(userNum0);
            int product = multiple * 50;
            Console.WriteLine("The answer is " + product);
            Console.WriteLine("Hit [Enter] to move on to the next step.");
            Console.ReadLine();

            //Take  input and add 25
            Console.WriteLine("Write any number you want 25 added to");
            string userNum1 = Console.ReadLine();
            int addend = Int32.Parse(userNum1);
            int sum = addend + 25;
            Console.WriteLine("The answer is " + sum);
            Console.WriteLine("Hit [Enter] to move on to the next step.");
            Console.ReadLine();

            //takes input and divides by 12.5
            Console.WriteLine("write any number you want divided by 12.5");
            string usernum2 = Console.ReadLine();
            double dividend0 = Int32.Parse(usernum2);
            double quotient = dividend0 / 12.5;
            Console.WriteLine("the answer is " + quotient);
            Console.WriteLine("Hit [Enter] to move on to the next step.");
            Console.ReadLine();

            //takes input and checks if it is greater than 50 then prints true/false
            Console.WriteLine("Write any number you will be compare as greater than 50");
            string userNum3 = Console.ReadLine();
            int numeral = Int32.Parse(userNum3);
            bool compare = numeral > 50;
            Console.WriteLine(numeral + " is greater than 50: " + compare);
            Console.WriteLine("Hit [Enter] to move on to the next step.");
            Console.ReadLine();

            //takes input and divides by 7 and prints the remainder
            Console.WriteLine("Write any number you want divided by 7. This will only display remainders");
            string userNum4 = Console.ReadLine();
            double dividend1 = Int32.Parse(userNum4);
            double quotient2 = dividend1 % 7;
            Console.WriteLine(quotient2);
            Console.WriteLine("Press [Enter] to close");
            Console.ReadLine();
        }
    }
}
