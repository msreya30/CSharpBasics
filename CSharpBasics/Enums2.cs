using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Enums2
    {
        public void bulit()
        {
            Working[] working = new Working[3];
            working[0] = new Working
            {
                Name = "keertana",
                Gender = Gender.Female
            };
            working[1] = new Working
            {
                Name = "john",
                Gender = Gender.Male
            };
            working[2] = new Working
            {
                Name = "regina",
                Gender = Gender.unknown
            };
            foreach (Working workings in working)
            {
                Console.WriteLine("Name={0} && Gender={1}", workings.Name, GetGender(workings.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.unknown:
                    return "unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "invalid data detected";
            }
        }
    }
        public enum Gender
        {
            unknown,
            Male,
            Female
        }
//0-unknown
//1-Male
//2-Female
public class Working
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}
}


