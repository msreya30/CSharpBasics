using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
  public  class Builder
    {
        public void cons()
        {
            StringBuilder userString = new StringBuilder("c#");
            userString.Append("video");
            userString.Append("Tutorial");
            userString.Append("for");
            userString.Append("Beginers");
            Console.WriteLine(userString);
         }
    }
}
