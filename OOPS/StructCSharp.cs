using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    struct Customer
    {
        public string name;
        public int id;

        public void setName(string name)
        {
            this.name = name;
        }
        
        public void setId(int id)
        {
            this.id = id;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: {0} \n Id: {1}", this.name, this.id);
        }
    }
    class StructCSharp
    {
        public void StructDemo()
        {
            Customer c = new Customer();
            c.setName("ABC");
            c.setId(001);
            c.PrintDetails();
        }
    }
}
