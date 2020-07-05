using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public delegate void HiFunctionDelegate(string Message);
    class Bussiness
    {
        public void earn()
        {
            HiFunctionDelegate del = new HiFunctionDelegate(Hi);
            del("Hi from delegate");
        }

        public void Hi(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
