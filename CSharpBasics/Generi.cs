using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Generi
    {
        public void prop()
        {
            bool Equal = Calculate<int>.AreEqual(15 ,10);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculate<T>
    {
public static bool AreEqual(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
    }

}
