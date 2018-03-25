using System;
using System.Runtime.Serialization;

namespace m0201.Exceptions
{
    [Serializable]
    public class UserInputException : Exception
    {
        public UserInputException()
        { }

        public UserInputException(string message) : base(message)
        { }

        public UserInputException(string message,
                                  Exception inner) : base(message,
                                                          inner)
        { }

        protected UserInputException(SerializationInfo info,
                                     StreamingContext context) : base(info,
                                                                      context)
        { }
    }
}
