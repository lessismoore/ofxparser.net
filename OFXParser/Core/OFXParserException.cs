using System;

namespace OFXParser.Core
{
    public class OFXParserException : Exception
    {
        public OFXParserException(String message) : base(message)
        {

        }

        public OFXParserException(String message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
