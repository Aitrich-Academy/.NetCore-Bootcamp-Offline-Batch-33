using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Machine_Test.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string msg) 
            : base(msg) 
        { }

    }
}