using System;

namespace Exceptions.DataBaseExceptions
{
    public class ConstraintViolatedException : Exception
    {
        private string _message;

        public ConstraintViolatedException()
        {
            _message = "Unique or primary key constraint violated.";
        }

        public ConstraintViolatedException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}