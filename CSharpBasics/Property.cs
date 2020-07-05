using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace CSharpBasics
{
    public class Property
    {
        public void props()
        {
            Type T = Type.GetType("CSharpBasics.Maintain");
            Console.WriteLine("FullName={0}", T.FullName);
            Console.WriteLine("just the Name={0}", T.Name);
            Console.WriteLine("just the Namespace={0}", T.Namespace);
            Console.WriteLine();

            Console.WriteLine("properties in Maintain");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + "" + property.Name);
            }
            Console.WriteLine();
            Console.WriteLine("methods in Maintain");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "" + method.Name);
            }
            Console.WriteLine();
            Console.WriteLine("constructors in Maintain");

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

        }

    }

    public class Maintain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Maintain(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Maintain()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void printID()
        {
            Console.WriteLine("ID={0}", this.Id);
        }
        public void printName()
        {
            Console.WriteLine("Name={0}", this.Name);
        }
    }
}
