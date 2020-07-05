using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Sreya
    {
        public void machanic()
        {
            List<Employ> empList = new List<Employ>();
            empList.Add(new Employ() { ID = 101, Name = "keertana", Salary = 70000, Experience = 6 });
            empList.Add(new Employ() { ID = 102, Name = "john", Salary = 40000, Experience = 4 });
            empList.Add(new Employ() { ID = 103, Name = "regina", Salary = 9000, Experience = 8 });
            empList.Add(new Employ() { ID = 104, Name = "surya", Salary = 100000, Experience = 3 });
            IsPromotable isPromotable = new IsPromotable(Promote);
            Employ.PromoteEmploy(empList,isPromotable);
        }
        public static  bool Promote(Employ emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            }
        }
    delegate bool IsPromotable(Employ empl);
    class Employ
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmploy(List<Employ> employList,IsPromotable IsEligibleToPromote)
        {
            foreach (Employ es in employList)
            {
                if (IsEligibleToPromote(es))
                {
                    Console.WriteLine(es.Name + "promoted");
                }
            }
        }

    }
}
