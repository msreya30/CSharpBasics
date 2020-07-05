using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
   public class Worker
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class  Prints
    {
        public void money()
        {
            int i = 10;
            int j = i;
            j = j + 1;
            Console.WriteLine("i={0} && j={1}", i, j);
            Worker w1 = new Worker();
            w1.ID = 1;
            w1.Name = "sreya";
            Console.WriteLine("w1.ID={0} && w1.Name={0}", w1.ID, w1.Name);
            
        }
    }
}
