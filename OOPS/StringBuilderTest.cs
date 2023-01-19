using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class StringBuilderTest
    {
        public void StringBuilderDemo()
        {
            string text = "Demo";
            StringBuilder text2 = new StringBuilder("Demo");
            Console.WriteLine("Using string type to append test: {0}", String.Concat(text, " text"));
            Console.WriteLine("Using stringbuilder to append test: {0}", text2.Append(" text"));
        }
    }
}
