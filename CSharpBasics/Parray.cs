using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Parray
    {
        public void numrs()
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            //paramsmethod();
            paramsmethod(numbers);
        }
        public static void paramsmethod(params int[] numbers)
        {
            Console.WriteLine("there are {0} elements ", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}


