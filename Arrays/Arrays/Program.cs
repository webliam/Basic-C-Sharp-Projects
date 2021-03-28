using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of Strings//
            /*Create a one-dimensional Array of strings. Ask the user to 
             * select an index of the Array and then display the string at 
             * that index on the screen.*/

            Console.WriteLine("Top 4 favourit fruit ");
            Console.WriteLine("Please enter a number to see which fruit fills that rank.");
            String[] Names = { "0 is not a rank.", "Apple", "Banana", "Olive", "Orange" };
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(Names[i]));
            Console.ReadLine();



            //Array of Integers//

            Console.WriteLine("How many apples to you need for your apple pie(s)?");
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 8)
            {
                Console.WriteLine("That's too many apples!");
            }
            if (n <= 0)
            {
                Console.WriteLine("How can you make apple pie with no apples?");
            }
            else
                Console.WriteLine("I have " + nums[n] + " apples for you to make apple pie(s) with.");
            Console.ReadLine();
                        
            //List of Strings//

            List<string> stringList = new List<string>();
            stringList.Add("Red");
            stringList.Add("Pink");
            stringList.Add("Green");
            stringList.Add("Blue");
            stringList.Add("Gold");
            stringList.Add("Silver");
            stringList.Add("Gray");
            stringList.Add("Navi Blue");

            Console.WriteLine("Please select a number between 0 and 7");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex <= 7)
            {
                Console.WriteLine(stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("You must select a number between 0 and 7");
            }

            Console.ReadLine();


        }
    }
}
