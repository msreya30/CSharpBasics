using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
  public class ExceptionHandlingAbuse1
    { 
        public void ab()
        {
            try
            {
                Console.WriteLine("please enter a Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter a Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());
                            int Result = Numerator / Denominator;
                            Console.WriteLine("Reslut={0}", Result);
                        }
            catch (FormatException)
            {
                Console.WriteLine("please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("only numbers between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        }
    }



