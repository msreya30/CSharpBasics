using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class If
    {
        public void phn()
        {
            Console.WriteLine("please enter a number");
            int usernumber = int.Parse(Console.ReadLine());
            if(usernumber==1)
            {
                Console.WriteLine("your number is one");
            }
        }
    }
}
