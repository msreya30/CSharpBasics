using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpBasics
{
    class ExceptionHandling
    {
        public void welcome()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"F:\Shreya\CSharpBasics\CSharpBasics\Sample.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("please check if the file {0} exists", ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
                Console.WriteLine("Finally block");
            }
        }
    }
}

