using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class Game
    {
        public abstract void Display();
    }
    class AbstractCSharp : Game
    {
        public override void Display()
        {
            Console.WriteLine("Abstract Demo");
        }

       public void AbstractDemo()
        {
            Game g = new AbstractCSharp();
            g.Display();
        }

    }
}
