using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iteration Program");

            string[] characterNames = { "Harry", "Hermione", "Ron", "Neville", "Ginny", "Draco", "Cho", "Cedric" };

            // append strings to each item in an array
            Console.WriteLine("Please input text you would like appended to each character name in the array:");

            string appendText = Console.ReadLine();

            for (int i = 0; i < characterNames.Length; i++)
            {
                characterNames[i] = characterNames[i] + " " + appendText;
            }

            foreach (string name in characterNames)
            {
                Console.WriteLine(name);
            }

            // check list for matching contents (first instance)
            Console.WriteLine("For the following list of character names, you may enter text to search for.");

            List<string> names = new List<string>
            {
                "Frodo",
                "Samwise",
                "Merry",
                "Pippin",
                "Gandalf",
                "Legolas",
                "Gimli",
                "Aragorn",
                "Boromir"
            };

            for (int j = 0; j <= (names.Count - 1); j++)
            {
                Console.WriteLine(names[j]);
            }

            Console.WriteLine("Enter the text you wish to search for and we will find the first index that contains that text");
            string searchText = Console.ReadLine();
            int foundIndex = -1;

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Contains(searchText))
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex == -1)
            {
                Console.WriteLine("That text was not found in any of the names in the list.");
            }
            else
            {
                Console.WriteLine("Matching text first found at index: " + Convert.ToString(foundIndex));
            }

            // check list for matching contents, all instances
            Console.WriteLine("For the following list of names, you may enter text to search for.");
            List<string> classList = new List<string>
            {
                "Chris",
                "Charlie",
                "Anna",
                "Beth",
                "Chris",
                "Ashley",
                "Ashley",
                "Ashley",
                "Nick"
            };

            for (int j = 0; j < classList.Count; j++)
            {
                Console.WriteLine(classList[j]);
            }

            Console.WriteLine("Enter the text you wish to search for and we will find the index (or indices) that contains that text");
            List<int> foundIndices = new List<int>();
            string searchString = Console.ReadLine();

            for (int i = 0; i < classList.Count; i++)
            {
                if (classList[i].Contains(searchString))
                {
                    foundIndices.Add(i);
                }
            }

            if (foundIndices.Count == 0)
            {
                Console.WriteLine("That text was not found in any of the names in the list.");
            }
            else
            {
                Console.WriteLine("Matching text found at index or indices: ");
                foreach (int index in foundIndices)
                {
                    Console.WriteLine(Convert.ToString(index));
                }
            }

            Console.WriteLine("Finally, a class list with duplicates identified");

            // check for duplicates within a list and display, labeled as either the original or duplicate

            for (int i = 0; i < classList.Count; i++)
            {
                if (classList.LastIndexOf(classList[i]) >= i && classList.IndexOf(classList[i]) == i)
                {
                    Console.WriteLine(classList[i] + " (original)");
                }
                else
                {
                    Console.WriteLine(classList[i] + " (duplicate)");
                }
            }


            Console.ReadLine();
        }
    }

}

