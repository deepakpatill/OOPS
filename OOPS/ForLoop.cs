using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class ForLoop
    {
        public void ForLoopDemo()
        {
            Console.WriteLine("For Loop");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i: {0}", i);
            }

            Console.WriteLine("ForEach Loop");
            int[] numlist = new int[] { 1, 3, 5, 7 };
            foreach(int num in numlist)
            {
                Console.WriteLine("number: {0}", num);
            }
        }
    }
}
