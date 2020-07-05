using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;

namespace CSharpBasics
{
    public class CustomerExceptionDemo
    {
        public void teach()
        {
            try
            {
                throw new UserAlreadyLoggedException("user is loggeed in -no duplicate sessions allowed");
            }
            catch (UserAlreadyLoggedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Serializable]
            public class UserAlreadyLoggedException:Exception
        {
            public UserAlreadyLoggedException()
                :base()
            {
            }
            public UserAlreadyLoggedException(string message)
                :base(message)
            {
            }
            public  UserAlreadyLoggedException (string message,Exception innerException)
                :base(message,innerException )
            {
            }
            public  UserAlreadyLoggedException(SerializationInfo info,StreamingContext context)
                :base(info,context)
            {
            }

    }
}
            
}
        

    

