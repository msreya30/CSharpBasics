using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
   public  class Enums
    {
        public void recap()
        {
            Custm[] custr = new Custm[3];
            custr[0] = new Custm
            {
                Name = "keertana",
            Gender=2
            };
        custr[1] = new Custm
            {
                Name = "john",
            Gender = 1
            };
         custr[2] = new Custm
            {
                Name = "regina",
            Gender = 2,
            };
foreach(Custm cust in custr)
    {
    Console.WriteLine("Name={0} && Gender={1}",cust.Name,cust.Gender);
    }
    }
    public static string GetGender(int Gender)
{
    switch (Gender)
    {
        case 0:
            return "unknown";
        case 1:
            return "Male";
        case 2:
            return "Female";
        default:
                    return "invalid data detected";
                }
          }
//0-unknown
//1-Male
//2-Female
public class Custm
{
    public string Name { get; set; }
    public int Gender { get; set; }
}
}
}




               
