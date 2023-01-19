using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Operators
    {
        public void OperatorsDemo()
        {
            //Artimethic Operation
            string concat = "Sub" + "string";
            int num = 1 + 10;
            Console.WriteLine("Arthimetic Operator");
            Console.WriteLine(concat + " " + num);

            //Comparison operator
            bool check = num == 11 ? true : false;
            Console.WriteLine("Comparison Operator num is equal to 11: {0}", check);

            //Assignment operator
            int plus = num;
            Console.WriteLine("Assignment Operator {0}", plus);
        }

    }
}
