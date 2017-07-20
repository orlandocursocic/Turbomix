using System;
using System.Runtime.Serialization;

namespace TurboMix
{
    [Serializable]
    internal class RecetaRepetidaException : Exception
    {
        public RecetaRepetidaException()
        {
        }

        public RecetaRepetidaException(string message) : base(message)
        {
        }

        public RecetaRepetidaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RecetaRepetidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}