using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class MethodOverloading
    {
        public void Display(int a)
        {
            Console.WriteLine("a: {0}", a);
        }

        public void Display(int a, int b)
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }

        public void Display(int a, int b, int c)
        {
            Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);
        }

        public void MethodOverloadingDemo()
        {
            Display(1);
            Display(1, 2);
            Display(1, 2, 3);
        }

    }
}
