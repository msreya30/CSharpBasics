using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Employeees
    {
        public string FirstName = "FN";
        public string LastName = "LN";
        public virtual  void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }
    }

    public class PartTimeEmployeees : Employeees
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "part time");
        }
    }

    public class FullTimeEmployees : Employeees
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName + "full  time");
        }
    }
    public class TemporaryEmployeees : Employeees
    {
    }
    public class Empu
    {
        public void tied()
        {
            Employeees[] emp = new Employeees[4];
            emp[0] = new Employeees();
            emp[1] = new PartTimeEmployeees();
            emp[2] = new FullTimeEmployees();
            emp[3] = new TemporaryEmployeees();

            foreach (Employeees e in emp)
            {
                e.PrintFullName();
            }
        }
    }
}

