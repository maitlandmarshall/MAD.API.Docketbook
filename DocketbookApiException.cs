using System;
using System.Runtime.Serialization;

namespace MAD.API.Docketbook
{
    [Serializable]
    public class DocketbookApiException : Exception
    {
        public DocketbookApiException()
        {
        }

        public DocketbookApiException(string message) : base(message)
        {
        }

        public DocketbookApiException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DocketbookApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}