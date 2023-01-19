using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class AccessMod
    {
        public string text;
        protected string text1;
    }

    class AccessModifiers :  AccessMod
    {
        public void AccessModifersDemo()
        {
            Console.WriteLine("Public Modifier");
            AccessMod a = new AccessMod
            {
                text = "Test"
            };
            Console.WriteLine("text :" + a.text);
            base.text1 = "Demo";
            Console.WriteLine("text :" + base.text1);

        }
    }
}
