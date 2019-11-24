using CodevValidator.DefaultMessage;
using System;

namespace CodevValidator.Validation.Common
{
    public class RequiredValidation : IValidation
    {
        protected bool isSuccess = true;
        public bool IsSuccess => isSuccess;

        public string FieldName { get; set; } = null;
        public string FormatErrorMessage { get; set; } = null;

        public string GetErrorMessage()
        {
            if (!IsSuccess)
            {
                if (string.IsNullOrEmpty(FormatErrorMessage))
                {
                    FormatErrorMessage = CommonMessage.REQUIREDERROR;
                }
                else if (!FormatErrorMessage.Contains("{0}"))
                {
                    FormatErrorMessage = "{0} " + FormatErrorMessage;
                }

                return string.Format(FormatErrorMessage, FieldName);
            }
            else
            {
                return null;
            }
        }

        public bool Validate<T>(T value)
        {
            if (value is string)
            {
                isSuccess = !string.IsNullOrEmpty(value as string);
            }
            else if (value is Nullable)
            {
                isSuccess = (value as Nullable) != null;
            }
            else
            {
                throw new NotSupportedException(nameof(RequiredValidation));
            }

            return isSuccess;
        }
    }
}
