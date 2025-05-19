using System;

namespace Exceptions.DataBaseExceptions
{
    public class RecordNotFoundException : Exception
    {
        private string _message;

        public RecordNotFoundException()
        {
            _message = "Înregistrarea nu a fost găsită în baza de date.";
        }

        public RecordNotFoundException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}