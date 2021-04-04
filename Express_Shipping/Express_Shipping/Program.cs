using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express_Shipping
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight <= 50)
            {
                Console.WriteLine("what is your package's width? Please enter the package width:");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("what is your package's height?Please enter the package height:");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("what is your package's length? Please enter the package length:");
                int pkgLength = Convert.ToInt32(Console.ReadLine());
                int totalDime = pkgWidth + pkgHeight + pkgLength;
                if (totalDime <= 50)
                {
                    decimal shippingCost = pkgWeight * pkgWidth * pkgHeight * pkgLength / 100m;
                    string shippingCostString = shippingCost.ToString("C2");
                    Console.WriteLine("Your estimated total for shipping this package is: " + shippingCostString);
                    Console.WriteLine("Thank you.");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. For more information connect us.Have a nice day.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            Console.ReadLine();
        }
    }
}
