using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Test1
    {
        public string name;
        public Gender gender;
        
    }
    enum Gender
    {
        Unknown,
        Male,
        Female,
        
    }
    class Enum
    {
        public void EnumDemo()
        {
            Test1 t = new Test1();
            t.name = "ABC";
            t.gender = Gender.Male;
            Console.WriteLine("Name: {0} \nGender: {1}", t.name, t.gender);
        }
    }
}
