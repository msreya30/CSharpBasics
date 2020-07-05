using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
     public  class ExceptionHandlingAbuse
    {
        public void handle()
        {
            try
            {
                Console.WriteLine("please enter a Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (IsNumeratorConversionSuccessful)
                {
                    Console.WriteLine("please enter a Denominator");
                    int Denominator;
                    bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (IsDenominatorConversionSuccessful)
                        if (IsDenominatorConversionSuccessful && Denominator != 0)
                        {
                            int Result = Numerator / Denominator;
                            Console.WriteLine("Reslut={0}", Result);
                        }
                        else
                        {
                            if (Denominator == 0)
                            {
                                Console.WriteLine("Denominator cannot be zero");
                            }
                            else
                            {
                                Console.WriteLine("Denominator should a valid number between {0}  &&{1}", Int32.MinValue, Int32.MaxValue);
                            }
                        }
                }
                else
                {
                    Console.WriteLine("Numerator should a valid number between {0}  &&{1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("only numbers between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                    

        }
    }
}
