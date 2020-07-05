using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Equal
    {
        public void es()
        {
            Custmr c5 = new Custmr();
            c5.FirstName = "sarika";
            c5.LastName = "bunny";

            Custmr c6 = new Custmr();
            c6.FirstName = "sarika";
            c6.LastName = "bunny";

            Console.WriteLine(c5 == c6);
            Console.WriteLine(c5.Equals(c6));
        }
    }
    public class Custmr
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
          if(obj==null)
            { 
                return false;
            }
            if (!(obj is Custmr))
            {
                return false;
            }
            return this.FirstName == ((Custmr)obj).FirstName &&
                  this.LastName == ((Custmr)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}

