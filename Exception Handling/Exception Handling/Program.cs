using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 100, 120, 140, 160, 180, 200 };
                Console.WriteLine("Please choose a number to be the divisor.");
                int divisor = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Length; i++)
                {
                    int answer = numbers[i] / divisor;
                    Console.WriteLine(numbers[i] + " divided by " + divisor + " equals " + answer);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("You have emerged from the try/catch block unscathed. Please continue.");
                Console.ReadLine();
            }
        }
    }
}

