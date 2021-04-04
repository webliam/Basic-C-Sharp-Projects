using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main()
        {
            // Concatenate three strings
            string firstName = "Steven";
            string middleName = "Paul";
            string lastName = "Jobs";
            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(fullName);

            // Uppercase a string
            string alertMsg = "This is important alert message";
            Console.WriteLine(alertMsg.ToUpper());

            // Use StringBuilder
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("February 24, 1955 – October 5, 2011) was an American business magnate, industrial designer, investor, and media proprietor.");
            paragraph.Append("Jobs and Wozniak co-founded Apple in 1976 to sell Wozniak's Apple I personal computer");
            paragraph.Append("Jobs became CEO of Apple in 1997, \n" +
                            "following his company's acquisition of NeXT. He was largely responsible for helping revive Apple, \n" +
                            "which had been on the verge of bankruptcy.");

            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
