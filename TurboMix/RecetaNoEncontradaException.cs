using System;
using System.Runtime.Serialization;

namespace TurboMix
{
    [Serializable]
    internal class RecetaNoEncontradaException : Exception
    {
        public RecetaNoEncontradaException()
        {
        }

        public RecetaNoEncontradaException(string message) : base(message)
        {
        }

        public RecetaNoEncontradaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RecetaNoEncontradaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}