using System;

namespace JobProvider
{
    internal class DuplicateUserException : Exception
    {
        public DuplicateUserException(string message) : base(message) { }
    }

    internal class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException(string message) : base(message) { }
    }

    internal class JobNotFoundException : Exception
    {
        public JobNotFoundException(string message) : base(message) { }
    }

    internal class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message) { }
    }
}