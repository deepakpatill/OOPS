using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class IfelseCSharp
    {
        public void IfelseDemo()
        {
            int num1 = 20;
            int num2 = 10;
            if (num1 == num2)
            {
                Console.WriteLine("num1 is equal to num2");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("num1 is greater than num2");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("num1 is less than num2");
            }
            else
            {
                Console.WriteLine("No conditions satisfied");
            }
        }
    }
}
