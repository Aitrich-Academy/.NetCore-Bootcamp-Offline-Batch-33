using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Activity__Negative_number_
{
    public class NegativeNumber : Exception
    {
        public NegativeNumber(string msg)
            :base(msg)
        { }
    }
}
