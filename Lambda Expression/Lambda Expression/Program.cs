using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Joe", LastName = "Green", Id = 1 });
            employees.Add(new Employee { FirstName = "Joe", LastName = "Yellow", Id = 2 });
            employees.Add(new Employee { FirstName = "John", LastName = "Smith", Id = 3 });
            employees.Add(new Employee { FirstName = "John", LastName = "Doe", Id = 4 });
            employees.Add(new Employee { FirstName = "James", LastName = "Davidson", Id = 5 });
            employees.Add(new Employee { FirstName = "David", LastName = "Johnson", Id = 6 });
            employees.Add(new Employee { FirstName = "Johnny", LastName = "Rogers", Id = 7 });
            employees.Add(new Employee { FirstName = "Jason", LastName = "Hawkins", Id = 8 });
            employees.Add(new Employee { FirstName = "Fanny", LastName = "May", Id = 9 });
            employees.Add(new Employee { FirstName = "Jane", LastName = "Doe", Id = 10 });

            List<Employee> Templist = new List<Employee>();
            foreach (var employee in employees)
            {

                if (employee.FirstName == "Joe")
                {
                    Templist.Add(employee);
                }
            }
            
            foreach (Employee employee in Templist)
            {
                Console.WriteLine(employee.FirstName);
            }

            List<Employee> joe = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in joe)
            {
                Console.WriteLine(employee.FirstName);
            }

            List<Employee> GreatThanFive = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("list of all employees with an Id number greater than 5");


            foreach (Employee employee in GreatThanFive)
            {
                Console.WriteLine("First Name : " + employee.FirstName + "Last Name : " + employee.LastName + "ID : " + employee.Id);
            }
            Console.ReadLine();
        }
    }
}
