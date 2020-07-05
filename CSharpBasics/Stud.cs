using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Stud
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;
        public int passMark
        {
            get
            {
                return this._passMark;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "no Name" : this._Name;
            }
        }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("student id cannot be negetive");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public class Programs
        {
            public void pri()
            {
                Stud  c2 = new Stud();
                c2.Id=101;
                c2.Name="mark";
                Console.WriteLine("Students Id={0}", c2.Id);
                Console.WriteLine("Students Name={0}", c2.Name);

                Console.WriteLine("Students passmark={0}", c2.passMark);
            }

        }
    }
}
    



    

