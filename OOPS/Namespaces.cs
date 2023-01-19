using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Class1
    {
        public void Print()
        {
            Console.WriteLine("From Class1");
        }
    }

    class Class2
    {
        public void Print()
        {
            Console.WriteLine("From Class2");
        }
    }

    class Namespaces
    {
        public void NamespacesDemo()
        {
            OOPS.Class1 c1 = new OOPS.Class1();
            c1.Print();
            OOPS.Class2 c2 = new OOPS.Class2();
            c2.Print();

        }
    }
}
