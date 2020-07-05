using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Work
    {
        public void machine()
        {
            List<Employi> empList = new List<Employi>();
            empList.Add(new Employi() { ID = 101, Name = "keertana", Salary = 70000, Experience = 6 });
            empList.Add(new Employi() { ID = 102, Name = "john", Salary = 40000, Experience = 4 });
            empList.Add(new Employi() { ID = 103, Name = "regina", Salary = 9000, Experience = 8 });
            empList.Add(new Employi() { ID = 104, Name = "surya", Salary = 100000, Experience = 3 });
            Employi.PromoteEmployi(empList);
        }
    }
  class Employi
    {
        public int ID { get; set;}
        public string  Name{ get; set;}
        public int Salary{ get; set;}
        public int Experience { get; set;}
        public static void PromoteEmployi(List<Employi>employiList)
        {
            foreach(Employi es in employiList)
            {
                if(es.Experience>=5)
                {
                    Console.WriteLine(es.Name + "promoted");
                }
            }
        }

    }


}
    

