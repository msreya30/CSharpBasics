using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class coffe
    { 
     public void doll()
        {
            int totalcoffeecost = 0;
            Start:
            Console.WriteLine("1-small,2-medium,3-large");
            int userchoice = int.Parse(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    totalcoffeecost += 1;
                    break;
                case 2:
                    totalcoffeecost += 2;
                    break;
                case 3:
                    totalcoffeecost += 3;
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid", userchoice);
                    break;
            }
            Decide:
            Console.WriteLine("do u want to buy another coffe-yes or no?");
            string userdecision = Console.ReadLine();
            switch(userdecision)
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("your choice{0} is invalid.please try again... ",userdecision);
                    goto Decide;

            }
            Console.WriteLine("thank for shopping with us") ;
            Console.WriteLine("bill amount={0}", totalcoffeecost);
        }
    }
}
