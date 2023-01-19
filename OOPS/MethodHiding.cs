using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class ClassA
    {
        public void Print()
        {
            Console.WriteLine("test");
        }
    }
    public class ClassB: ClassA
    {
        public new void Print()
        {
            Console.WriteLine("TEST");
        }
    }
    class MethodHiding
    {
        public void MethodHidingDemo()
        {
            ClassB a = new ClassB();
            a.Print();

            ClassA obj = new ClassB();
            obj.Print();

        }
    }
}
