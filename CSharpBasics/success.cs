using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Success
    {
        public void preg()
        {
            string strnumber = "100tg";
            int result = 0;
            bool isconversionsuccessful = int.TryParse(strnumber, out result);
            if (isconversionsuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("please enter a valid number");
            }
        }
    }
}
