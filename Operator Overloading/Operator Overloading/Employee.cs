using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Employee : Person
    {
        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)
            {
                bool isEqual = true;
                return isEqual;
            }
            else
            {
                bool isEqual = false;
                return isEqual;
            }
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.ID != employee1.ID)
            {
                bool isNotEqual = true;
                return isNotEqual;
            }
            else
            {
                bool isNotEqual = false;
                return isNotEqual;
            }

        }


    }
}
