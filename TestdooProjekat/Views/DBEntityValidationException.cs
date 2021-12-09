using System;
using System.Runtime.Serialization;

namespace TestdooProjekat.Views
{
    [Serializable]
    internal class DBEntityValidationException : Exception
    {
        public DBEntityValidationException()
        {
        }

        public DBEntityValidationException(string message) : base(message)
        {
        }

        public DBEntityValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DBEntityValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}