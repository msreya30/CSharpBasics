using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class For
    {
        public void array()
        {
            int[] numbers = new int[3];
            numbers[0]= 101;
            numbers[1] = 102;
            numbers[2] = 103;
            for(int j=0;j<numbers.Length;j++)
            {
                Console.WriteLine(numbers[j]);
            }
            int i = 0;
            while(i<numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
        }
    }
}
