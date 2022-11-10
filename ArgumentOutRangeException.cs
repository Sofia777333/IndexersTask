using System.Runtime.Serialization;

namespace IndexersTask
{
    [Serializable]
    internal class ArgumentOutRangeException : Exception
    {
        public ArgumentOutRangeException()
        {
        }

        public ArgumentOutRangeException(string? message) : base(message)
        {
        }

        public ArgumentOutRangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ArgumentOutRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}