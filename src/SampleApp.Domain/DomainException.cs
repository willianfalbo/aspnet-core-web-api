﻿using System;

namespace SampleApp.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string error) : base(error)
        {
        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new Exception(error);
        }
    }
}
