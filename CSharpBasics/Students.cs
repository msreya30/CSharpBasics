using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Students
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;

        public int GetPassMark()
        {
            return this._passMark;
        }
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "no Name" : this._Name;
        }
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Students id cannot be negetive");
            }
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;
        }
        public class Programss
        {
            public void prime()
            {
                Students c1 = new Students();
                c1.SetId(101);
                c1.SetName("mark");
                Console.WriteLine("Students Id={0}", c1.GetId());
                Console.WriteLine("Students Name={0}", c1.GetName());

                Console.WriteLine("Students passmark={0}", c1.GetPassMark());
            }
        }
    }
}




    

