using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public abstract class Workers
    { 
public abstract void Print();
    }
    public class Duty:Workers
    {
        public override void Print()
        {
            Console.WriteLine("Print method");
        }
        public void meeting()
        {
            Workers wc = new Duty();
            wc.Print();
        }

    }
}
