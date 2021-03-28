using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithThreeMethods
{
    public class SimpleMath
    {


        public void simpleMethod(int userNum1)
        {
            int difference = userNum1 / 2;
            Console.WriteLine(difference);
        }

        public void simpleMethod(int userNum2, out int answer1, out int answer2)
        {
            answer1 = userNum2 + 10;
            answer2 = userNum2 * 2;
            Console.WriteLine(userNum2+" + 10 ="+ answer1);
            Console.WriteLine(userNum2 + "x 2 ="+ answer2);

        }
    }
}
