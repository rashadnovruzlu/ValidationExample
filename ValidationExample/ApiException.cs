using System;
using System.Collections.Generic;

namespace ValidationExample
{
    public class ApiException : Exception
    {
        public ResponseMessage StatusCode { get; set; }

        public IEnumerable<ValidationError> Errors { get; set; }
 
    }
}
