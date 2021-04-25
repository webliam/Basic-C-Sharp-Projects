using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_I_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a number: ");
            string inputNum = Console.ReadLine();
            string filePath = @"C:\Users\mana\logs\numlog.txt";
            string returnText;
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(inputNum);
            }
            using (StreamReader file = new StreamReader(filePath, true))
            {
                returnText = file.ReadToEnd().ToString();
            }

            Console.WriteLine("Number logged to: {0}", filePath);
            Console.WriteLine("File contents:");
            Console.WriteLine(returnText);

            Console.Read();
        }

    }
}
