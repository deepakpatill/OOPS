using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class ExceptionHandling
    {
        public void ExceptionHandlingDemmo()
        {
            try
            {
                int num = 0;
                int result = 50 / num;

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
