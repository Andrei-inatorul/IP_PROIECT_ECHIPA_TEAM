using System;

namespace Exceptions.DataBaseExceptions
{
    public class InvalidStockException : Exception
    {
        private string _message;

        public InvalidStockException()
        {
            _message = "Stocul nu poate fi negativ.";
        }

        public InvalidStockException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}