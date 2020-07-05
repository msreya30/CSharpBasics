using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
 public    class Over
    {
        public void ts()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Custo c4 = new Custo();
            c4.FirstName = "sreya";
            c4.LastName = "vaish";
            Console.WriteLine(Convert.ToString(c4));
        }
    }
    public class Custo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return this.LastName + "" + this.FirstName;

        }

    }
}
