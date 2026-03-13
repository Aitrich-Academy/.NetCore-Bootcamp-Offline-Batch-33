using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Activity__Minimum__Balence_
{
    public class InsufficientBalence : Exception
    {
        public InsufficientBalence(string msg) : base(msg)
        {

        }
    }
}
