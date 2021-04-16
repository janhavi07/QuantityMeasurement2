using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_measurement
{
    public class CustomException :Exception
    {
        public enum ExceptionType
        {
            NullValueException
        }

        ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
