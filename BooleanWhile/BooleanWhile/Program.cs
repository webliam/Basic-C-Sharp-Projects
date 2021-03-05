using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            //WHILE loop

            Console.WriteLine("Can you guess my favorite color");
            string color = Console.ReadLine();
            bool guess = color == "empty";

            while (!guess)
            {
                switch (color)
                {
                    case "silver":
                        Console.WriteLine("Ooo Gooch! You're getting closer! Try again.");
                        color = Console.ReadLine();
                        break;

                    case "white":
                        Console.WriteLine("oMmmmm. Boring! Try again.");
                        color = Console.ReadLine();
                        break;

                    case "pink":
                        Console.WriteLine("It's not my favourit Color, Boring! Try again.");
                        color = Console.ReadLine();
                        break;

                    case "black":
                        Console.WriteLine("That's too dark. Try again.");
                        color = Console.ReadLine();
                        break;

                    case "gold":
                        Console.WriteLine("Wow! That's it!");
                        guess = true;
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Hmmm. Nope! Try again.");
                        color = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
