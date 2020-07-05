using System;
using System.Collections.Generic;
using System.Text;
using static CSharpBasics.Employees;

namespace CSharpBasics
{
    public class Employees
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }
    }

    public class FullTimeEmployee : Employees
    {
        public float YearlySalary;

    }

    public class PartTimeEmployee : Employees
    {
        public float HourlyRate;
    }

    public class Emp
    {
        public  void type()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "sreya";
            FTE.LastName = "tech";
            FTE.YearlySalary = 50000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "part";
            PTE.LastName = "time";
            PTE.PrintFullName();
        }
    }

}    
        
    

