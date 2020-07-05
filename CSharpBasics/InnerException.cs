using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpBasics
{
    class InnerException
    {
        public void technology()
        {
            try
            {
                Console.WriteLine("Enter a first number");
                int FN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                int SN = Convert.ToInt32(Console.ReadLine());
                int Result = FN / SN;
                Console.WriteLine("Reslut={0}", Result);
            }
            catch(Exception ex)
            {
                string filepath= @"F:\Shreya\CSharpBasics\CSharpBasics\Sample.txt";
                StreamWriter sw = new StreamWriter(filepath);
                sw.Write(ex.GetType().Name);
                sw.WriteLine(ex.Message);
                sw.Close();
                Console.WriteLine("there is a problem ,please try later");
            }
            }
        }
    }


