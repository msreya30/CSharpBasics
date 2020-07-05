using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
  public  class Employeee
    {
       
        public string FirstName;
        public string LastName;

      public  void PrintFulName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }
    }

    public class PartTimeEmployeee : Employeee
    {
        public PartTimeEmployeee()
        {

            PrintFulName();
            //Console.WriteLine(FirstName + "" + LastName +"- Contractor");
        }

    }

    public class FullTimeEmployeee : Employeee
    {
        public new void PrintFulName()
        {
            base.PrintFulName();
            //Console.WriteLine(FirstName + "" + LastName +"- Contractor");
        }
    }

    public class Spu
    {
        public void time()
        {
            FullTimeEmployeee FTE = new FullTimeEmployeee();
            FTE.FirstName = "fulltime";
            FTE.LastName = "employee";
            FTE.PrintFulName();

            PartTimeEmployeee PTE = new PartTimeEmployeee();
            PTE.FirstName = "part";
            PTE.LastName = "time";
            ((Employeee)PTE).PrintFulName();
        }
    }

}    
        
    


    

