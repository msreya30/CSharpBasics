using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Enums3
    {
        public void def()
        {
            int[] Values = (int[])Enum.GetValues(typeof(Gender));
            foreach (short value in Values)
            {
                Console.WriteLine(value);
            }
            string[] Names = Enum.GetNames(typeof(Gender));
            foreach(string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }
}

enum Gender:short
        {
            unknown = 1,
            Male = 3,
            Female = 9
        }
    
       
