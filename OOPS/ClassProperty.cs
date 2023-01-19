using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        private string name;

        public void setName(string s)
        {
            this.name = s;
        }

        public string getName()
        {
            return this.name;
        }
    }
    class ClassProperty
    {
        public void ClassPropertyDemo()
        {
            Student s = new Student();
            Console.WriteLine("Set name using setName property");
            s.setName("ABC");
            Console.WriteLine("Get name using getname property , Name: {0}", s.getName());
           
        }
    }
}
