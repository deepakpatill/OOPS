using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Async
    {
        static async void Task1()
        {
            Console.WriteLine("Task1 Started");
            await Task.Delay(2000);
            Console.WriteLine("Task1 Completed");
        }

        static void Task2()
        {
            Console.WriteLine("Task2 Started");
            Console.WriteLine("Task2 Completed");
        }

        public void AsyncDemo()
        {
            Task1();
            Task2();
    }
    }

}
