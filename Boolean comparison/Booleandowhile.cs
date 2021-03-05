using System;

namespace Boolean_Comparison_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //do while 
            Console.WriteLine("What is 6 * (100 / 100) + -5 * (10 / 10)?");
            int input2 = Convert.ToInt32(Console.ReadLine());
            bool answer =  input2 == 1;

            do
            {
                switch (input2)
                {
                    case 0:
                        Console.WriteLine("Close but try again");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You are correct!");
                        answer = true;
                        break;
                    default:
                        Console.WriteLine("Try again, hint: remnember to use PEMDAS.");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!answer);
            Console.ReadLine(); 
        }
    }
}