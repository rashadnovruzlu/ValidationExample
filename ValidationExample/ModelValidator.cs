using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public static class ModelValidator
    {
        public static async Task IsValidAsync(BaseValidation validation)
        {
            if (validation == null) throw new ArgumentNullException();

            if (await validation.IsValidAsync())
            {
                throw validation;
            }
        }
    }
}
