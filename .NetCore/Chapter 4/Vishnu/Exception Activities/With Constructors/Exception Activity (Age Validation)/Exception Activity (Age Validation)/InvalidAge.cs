using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Activity__Age_Validation_
{
    public class InvalidAge : Exception
    {
        public InvalidAge(string msg):base(msg)
        {

        }
    }
}
