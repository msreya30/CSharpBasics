using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Maincls
    {
        private  void sharp()
        {

            Calculators.Add(new List<int>() { 10, 20, 40 });

        }
        public class Calculators
        {
            [Obsolete("Use Add(List<int>Numbers) Method")]
            public static int Add(int FirstNumber, int SecondNumber)
            {
                return FirstNumber + SecondNumber;
            }
            public static int Add(List<int> Numbers)
            {
                int Sum = 0;
                foreach (int Number in Numbers)
                {
                    Sum = Sum + Number;
                }
                return Sum;

            }
        }
    }
}

