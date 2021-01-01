using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ValidationExample
{
    public abstract class BaseValidation : ApiException
    {
       
        [JsonIgnore]
        public List<ValidationError> ValidationErrors { get; set; } = new List<ValidationError>();

        public abstract Task<bool> IsValidAsync();

        public bool Validate()
        {
            Errors = ValidationErrors;

            return ValidationErrors.Any();
        }
    }
}
