using System;

namespace MathAndComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            int hrRate1 = Convert.ToInt32(hourlyRate1);
            Console.WriteLine("Hours worked per week?");
            string hoursWorkedPerWeek1 = Console.ReadLine();
            int hrWorkedPerWk1 = Convert.ToInt32(hoursWorkedPerWeek1);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            int hrRate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string hoursWorkedPerWeek2 = Console.ReadLine();
            int hrWorkedPerWk2 = Convert.ToInt32(hoursWorkedPerWeek2);
            
            //result person 1
            Console.WriteLine("Annual salary of Person 1:");
            int weeksPerYear = 52;
            int choose1 = hrRate1 * hrWorkedPerWk1 * weeksPerYear;
            Console.WriteLine(choose1);
            Console.ReadLine();
            
            //result person 2
            Console.WriteLine("Annual salary of Person 2:");
            int choose2 = hrRate2 * hrWorkedPerWk2 * weeksPerYear;
            Console.WriteLine(choose2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = choose1 > choose2;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}