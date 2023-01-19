using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class SwitchCase
    {
        public void SwitchCaseDemo()
        {
            int num = 5;
            switch (num)
            {
                case 5:
                    Console.WriteLine("Value: {0}", num);
                    break;
                case 15:
                    Console.WriteLine("Value: {0}", num);
                    break;
                case 25:
                    Console.WriteLine("Value: {0}", num);
                    break;
                default:
                    Console.WriteLine("Unknown Value");
                    break;
            }
        }
    }
}
