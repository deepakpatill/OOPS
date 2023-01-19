using System;

namespace OOPS
{
    public partial class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;


        //Polymorphism
        public virtual void DisplayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        //Polymorphism
        public override void DisplayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " - Full Time");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;

        //Polymorphism
        public override void DisplayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " - Part Time");
        }
    }

    class Inheritance
    {
       public void DemoInheritance()
        {
            FullTimeEmployee FTM = new FullTimeEmployee
            {
                FirstName = "ABC",
                LastName = "PQR",
                Email = "abc@demo.com",
                YearlySalary = 1500000
            };
            Console.WriteLine("Full Time Employee");
            FTM.DisplayName();

            PartTimeEmployee PTM = new PartTimeEmployee
            {
                FirstName = "XYZ",
                LastName = "DEF",
                Email = "xyz@demo.com",
                HourlySalary = 500
            };
            Console.WriteLine();
            Console.WriteLine("Part Time Employee");
            FTM.DisplayName();
            Console.WriteLine();
        } 

    }
}
