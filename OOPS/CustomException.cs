using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Demo
    {
        public string name = "123";
    }

    [Serializable]
    class InvalidNameException : Exception
    {
        public InvalidNameException() { }
        public InvalidNameException(string name) : base(String.Format("Invalid Name: {0}", name)){ }

    }
    class CustomException
    {
        public void CustomExceptionDemo()
        {
            Demo d = new Demo();

            try
            {
                if (d.name != "ABC")
                {
                    throw new InvalidNameException(d.name);
                }
            }
            catch (InvalidNameException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
