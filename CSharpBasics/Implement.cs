using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    public class Implement : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 interface method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }
        public void Explicit()
        {
            Implement im = new Implement();
            ((I1)im).InterfaceMethod();
            ((I2)im).InterfaceMethod();
        }
    }
}

