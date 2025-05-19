using System;

namespace Exceptions.DataBaseExceptions
{
    public class InvalidExtensionException : Exception
    {
        private string _message;

        public InvalidExtensionException()
        {
            _message = "Extensie fișier invalidă!";
        }

        public InvalidExtensionException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}