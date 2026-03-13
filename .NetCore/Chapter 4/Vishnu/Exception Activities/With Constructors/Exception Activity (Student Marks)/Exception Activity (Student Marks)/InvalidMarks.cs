using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Activity__Student_Marks_
{
    internal class InvalidMarks : Exception
    {
        public InvalidMarks(string msg)
            :base(msg)
        { }
    }
}
