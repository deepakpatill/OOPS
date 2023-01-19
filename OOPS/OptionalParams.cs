using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class OptionalParams
    {
        public void Add(int a, int b, params int[] numbers)
        {
            int result = a + b;
            Console.WriteLine("Sum without list is {0}", result);
            if (numbers != null)
            {
                foreach(int num in numbers)
                {
                    result += num;
                }
            }
            Console.WriteLine("Sum is {0}", result);
        }

        public void AddOA(int a, int b, [OptionalAttribute] int[] numbers)
        {
            int result = a + b;
            Console.WriteLine("Sum without list is {0}", result);
            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    result += num;
                }
            }
            Console.WriteLine("Sum is {0}", result);
        }

        public void Add(int a = 1, int b = 5)
        {
            int result = a + b;
            Console.WriteLine("Sum is {0}", result);
        }

        public void OptionalParametersDemo()
        {
            Console.WriteLine("Using Parameters");
            Add(1, 2,new int[] { 1, 2, 3});
            Console.WriteLine("Using Optional Attribute");
            AddOA(1, 2);
            Console.WriteLine("Using default parameter values");
            Add();
        }
    }
}
