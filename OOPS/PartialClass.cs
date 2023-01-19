using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public partial class EmployeeDetails
    {
        private string name;
        private int id;
        public EmployeeDetails(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        partial void Print();

        public void PartialMethod()
        {
            Print();
        }

    }
    class PartialClass
    {
        public void PartialClassDemo()
        {
            EmployeeDetails e = new EmployeeDetails("ABC",101);
            e.Display();
        }

        public void PartialMethodDemo()
        {
            EmployeeDetails e = new EmployeeDetails("ABC", 101);
            e.PartialMethod();
        }
    }
}
