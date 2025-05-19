using System;

namespace Exceptions.AccessRightsExceptions
{
    public class PermissionDeniedException : Exception
    {
        private string _message;

        public PermissionDeniedException()
        {
            _message = "Nu ai acces pentru acestă acțiune!";
        }

        public PermissionDeniedException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}