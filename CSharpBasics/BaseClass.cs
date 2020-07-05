using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("i am a Basecalss print method");
        }
    }
    public class Derivedclass : BaseClass
    {
        public new void Print() 
        {
            Console.WriteLine("i am a derived class method"); 
       }
    }
    public class student
    {
        public void roll()
        {
            BaseClass B = new Derivedclass();
            B.Print();
        }
    }
}
