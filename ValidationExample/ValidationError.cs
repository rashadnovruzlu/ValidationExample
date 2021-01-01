using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationExample
{
    public class ValidationError
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; }

        public string Message { get; }

        public ValidationType ValidationType { get; set; }

        public ValidationError(string field, string message)
        {
            Field = field != string.Empty ? field : null;
            Message = message;
        }

        public ValidationError(string field, ResponseMessage message, ValidationType validationType)
        {
            Field = field != string.Empty ? field : null;
            Message = message.GetDescription();
            ValidationType = validationType;
        }

        public ValidationError(string field, ResponseMessage message)
        {
            Field = field != string.Empty ? field : null;
            Message = message.GetDescription();
            ValidationType = HandleValidationType(message);
        }

        ValidationType HandleValidationType(ResponseMessage responseMessage)
        {

            switch (responseMessage)
            {
                case ResponseMessage.UserNotFound:
                    return ValidationType.Warning;

                case ResponseMessage.InvalidPassword:
                    return ValidationType.Warning;

                case ResponseMessage.UserAlreadyLoggedIn:
                    return ValidationType.Warning;

                case ResponseMessage.Locked:
                    return ValidationType.Warning;

                case ResponseMessage.FileNotFound:
                    return ValidationType.Warning;

                case ResponseMessage.NotValid:
                    return ValidationType.Required;

                case ResponseMessage.PropertyIsNull:
                    return ValidationType.Required;

                case ResponseMessage.PropertyAlreadyExists:
                    return ValidationType.AlreadyExists;

                case ResponseMessage.IdNotExists:
                    return ValidationType.Required;

                case ResponseMessage.RowAlreadyExists:
                    return ValidationType.Warning;

                case ResponseMessage.FileContentIsEmpty:
                    return ValidationType.Warning;

                case ResponseMessage.IncorrectSyntax:
                    return ValidationType.Warning;

                case ResponseMessage.MoreColumnCount:
                    return ValidationType.Warning;

                case ResponseMessage.NoPermission:
                    return ValidationType.Warning;

                default:
                    return ValidationType.Required;
            }
        }
    }
}
