namespace CSharpBasics
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { this._name = value; }

        }
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetails()
        {
            System.Console.WriteLine("Id={0} && Name={1}", this._id, this._name);
        }
    }
    public class Salary
    {
        public void collect()
        {
            Customer cs = new Customer(101, "Mark");
            cs.PrintDetails();
        }
    }
}





    

