using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Constructor
    {
        string text;
        static  string stext;

        //Default Constructor
        public Constructor()
        {
            this.text = "PlaceHolder";
        }

        //Parameterized constructor
        public Constructor(string text)
        {
            this.text = text;
        }

        //Copy Constructor
        public Constructor(Constructor c)
        {
            this.text = c.text;
        }

        //Static Constructor
        static Constructor()
        {
            stext = "Demo";
        }

        public void Display()
        {
            Console.WriteLine("Text" + " " + text);
            Console.WriteLine("Static Text" + " " + stext);
        }

        public void DemoConstructor()
        {
            //Default
            Constructor c1 = new Constructor
            {
                text = "Refactor"
            };
            c1.Display();

            //Paramter
            Constructor c2 = new Constructor("Test")
            {
                text = "Refactor"
            };
            c2.Display();

            //Copy
            Constructor c3 = new Constructor(c2)
            {
                text = "Refactor"
            };
            c3.Display();
        }
    }
}
