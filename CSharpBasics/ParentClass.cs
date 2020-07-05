using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass constructor called");
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("ChildClass constructor called");
        }
    }
    public class Es
    {
        public void spc()
        {
            ChildClass cc = new ChildClass();

        }
    }
}