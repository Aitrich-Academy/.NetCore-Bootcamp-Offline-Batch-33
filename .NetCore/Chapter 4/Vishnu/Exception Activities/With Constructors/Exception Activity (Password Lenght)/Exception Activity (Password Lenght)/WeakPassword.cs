using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Activity__Password_Lenght_
{
    public class WeakPassword : Exception
    {
        public WeakPassword( string Msg)
            :base(Msg)
        { }
    }
}
