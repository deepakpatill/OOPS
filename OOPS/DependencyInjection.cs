using System;
using System.Collections.Generic;

namespace OOPS
{
    
    public class EmployeeData
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public interface ISelectEmployeeDetails
    {
        List<EmployeeData> SelectAllEmployees();
    }

    public class SelectEmployeeDetails : ISelectEmployeeDetails
    {
        public List<EmployeeData> SelectAllEmployees()
        {
            List<EmployeeData> employees = new List<EmployeeData>
            {
                new EmployeeData { ID = 1, Name = "ABC"},
                new EmployeeData { ID = 2, Name = "PQR" },
                new EmployeeData { ID = 3, Name = "XYZ" },
            };
            return employees;
        }
    }

    //Constructor Injection
    public class GetEmployees
    {
        private ISelectEmployeeDetails employeeDetails;
        public GetEmployees(ISelectEmployeeDetails employeeDetails)
        {
            this.employeeDetails = employeeDetails;
        }
        public List<EmployeeData> GetEmployeesData()
        {
            return employeeDetails.SelectAllEmployees();
        }
    }

    //Property Injection
    public class PGetEmployees
    {
        private ISelectEmployeeDetails employeeDetails;
        public ISelectEmployeeDetails SelectEmployeeObject
        {
            set
            {
                this.employeeDetails = value; 
            }
            get
            {
                return employeeDetails;
            }
        }
        public List<EmployeeData> GetEmployeesData()
        {
            return employeeDetails.SelectAllEmployees();
        }
    }

    //Method Injection
    public class MGetEmployees
    {
        public ISelectEmployeeDetails employeeDetails;
        public List<EmployeeData> GetEmployeesData(ISelectEmployeeDetails employeeDetails)
        {
            this.employeeDetails = employeeDetails;
            return employeeDetails.SelectAllEmployees();
        }
    }

    class DependencyInjection  
    {
        public void ConstructorInjectionDemo()
        {
            Console.WriteLine("Costructor Injection Demo");
            GetEmployees e = new GetEmployees(new SelectEmployeeDetails());
            List<EmployeeData> employees = e.GetEmployeesData();
            foreach (EmployeeData emp in employees)
            {
                Console.WriteLine("ID: {0}, Name:{1}", emp.ID, emp.Name);
            }
        }

        public void PropertyInjectionDemo()
        {
            Console.WriteLine();
            Console.WriteLine("Property Injection Demo");
            PGetEmployees pi = new PGetEmployees
            {
                SelectEmployeeObject = new SelectEmployeeDetails()
            };
            List<EmployeeData> employees = pi.GetEmployeesData();
            foreach (EmployeeData emp in employees)
            {
                Console.WriteLine("ID: {0}, Name:{1}", emp.ID, emp.Name);
            }
        }
        public void MethodInjectionDemo()
        {
            Console.WriteLine();
            Console.WriteLine("Method Injection Demo");
            MGetEmployees em = new MGetEmployees();
            List<EmployeeData> employees = em.GetEmployeesData(new SelectEmployeeDetails());
            foreach (EmployeeData emp in employees)
            {
                Console.WriteLine("ID: {0}, Name:{1}", emp.ID, emp.Name);
            }
        }
    }
}
