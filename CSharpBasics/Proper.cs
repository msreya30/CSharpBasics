using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;

namespace CSharpBasics
{
    public class Proper
    {
        private string _firstName;
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string GetFullName()
        {
            return _firstName + "," + _lastName;
        }
    }
}


