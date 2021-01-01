using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationExample
{
    public enum ValidationType
    {
        Warning,
        AlreadyExists,
        Min,
        Max,
        MinLength,
        MaxLength,
        Email,
        Required
    }
}
