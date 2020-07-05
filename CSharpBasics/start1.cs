using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class start1
    {
        public void prime()
        {
            Console.WriteLine("please enter your target");
            int usertarget = int.Parse(Console.ReadLine());
            int Start = 0;
            while(Start<=usertarget)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}
