using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Activity__Age_Validation_
{
    public class ApplicationException
    {
        public void Handler(int age) 
        {
            if (age < 18)
            {
                throw new Exception("Under age !! Age should be 18 or greater");
            }

        }
    }
   
}
