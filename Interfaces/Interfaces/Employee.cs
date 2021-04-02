using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            IQuittable quittable = new Employee();
            Console.WriteLine("To exit, press enter.");
            Console.ReadLine();
        }
    }
}
