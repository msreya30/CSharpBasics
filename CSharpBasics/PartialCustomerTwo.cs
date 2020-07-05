using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;

namespace CSharpBasics
{
    public partial class  PartialCustomer


    {
        public string GetFullName()
        {

            return _firstName + "," + _lastName;
        }
    }
}



