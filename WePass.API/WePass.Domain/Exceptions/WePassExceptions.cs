using System;

namespace WePass.Domain.Exceptions
{
    public class WePassExceptions : Exception
    {
        public WePassExceptions()
        {

        }

        public WePassExceptions(string message) : base(message)
        {

        }

        public WePassExceptions(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
