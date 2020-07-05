using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    interface ICustomers1
    {
        void print1();
    }
    interface ICustomers2 : ICustomers1
    {
        void print2();
    }
    public class Customers : ICustomers2
    {
        public void print2()
        {
            Console.WriteLine("print2");
        }
        public void print1()
        {
            Console.WriteLine("print1");
        }
    }
    public class people
    {
        public void many()
        {
            Customers c3 = new Customers();
            c3.print1();
            c3.print2();
        }
    }
}


    


