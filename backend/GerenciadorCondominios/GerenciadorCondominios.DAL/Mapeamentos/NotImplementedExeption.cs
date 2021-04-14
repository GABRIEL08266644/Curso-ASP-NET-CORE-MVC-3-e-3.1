using System;
using System.Runtime.Serialization;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    [Serializable]
    internal class NotImplementedExeption : Exception
    {
        public NotImplementedExeption()
        {
        }

        public NotImplementedExeption(string message) : base(message)
        {
        }

        public NotImplementedExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotImplementedExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}