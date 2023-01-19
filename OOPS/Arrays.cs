using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Arrays
    {
        public void ArrayDemo()
        {
            int[] list1 = new int[5] { 1, 2, 3, 4, 5 };
            string[] list2 = new string[] { "Mumbai", "Pune", "Nashik" };
            Console.WriteLine("Integer array");
            foreach (var num in list1)
            {
                Console.Write(num + " ");
                Console.Write(" ");

            }
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.Write(item + " ");
                Console.Write(" ");

            }
        }
    }
}
