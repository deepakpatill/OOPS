using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class DoWhile
    {
        public void DoWhileDemo()
        {
            int i = 0;
            do
            {
                Console.WriteLine("i: {0}", i);
                i += 1;
            } while (i < 5);
        }
    }
}
