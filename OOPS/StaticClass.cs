using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    static class StaticClass
    {
        static string CarType = "Supercar";
        static string CarCategory = "Sports";

        public static void StaticClassDemo()
        {
            Console.WriteLine("Car Type is: {0}", StaticClass.CarType);
            Console.WriteLine("Car Category is: {0}", StaticClass.CarCategory);
        }
    }
}
