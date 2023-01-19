using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class StringConversion
    {
        public void StringConversionDemo()
        {
            string num = null;
            
            string text1 = Convert.ToString(num);
            Console.WriteLine("Using Convert.ToString(): {0}", text1);
            try
            {
                string text = num.ToString();
                Console.WriteLine("Using .ToString(): {0}", text.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            };
            

        }
    }
}
