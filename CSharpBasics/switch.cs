using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Switch
    {
        public void type()
        {
            Console.WriteLine("please enter a number");
            int usernumber = int.Parse(Console.ReadLine());
            switch(usernumber)
            {
                case 10:
                    Console.WriteLine("your number is 10");
                    break;
                case 20:
                    Console.WriteLine("your number is 20");
                    break;
                case 30:
                    Console.WriteLine("your number is 30");
                    break;
                default:
                    Console.WriteLine("your number is not 10,20&30");
                    break;
            }
            
        }

    }
}
