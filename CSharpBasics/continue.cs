using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Continue
    {
        public  void num()
        {
            for(int i=0;i<=20;i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
                Console.Read();
            }
        }

    }
}
