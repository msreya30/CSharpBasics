using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public delegate void SampleDelegate(out int Number);
    class Pargim
    {
        public void practice()
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo ;
            int DelegateOutputParamterValue;
            del(out DelegateOutputParamterValue);
            Console.WriteLine("DelegateOutputParamterValue={0}", DelegateOutputParamterValue);
        }
        public static  void SampleMethodOne(out int Number)
        {
            Number = 1;   
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
    }
}
