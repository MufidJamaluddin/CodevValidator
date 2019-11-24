using System;

namespace CodevValidator.Validation.String
{
    public class MaxLengthValidation : IValidation
    {
        public string FieldName { get; set; }
        public string FormatErrorMessage { get; set; }
        public int MaxLength { get; set; }

        public bool IsSuccess => throw new NotImplementedException();

        public string GetErrorMessage()
        {
            throw new NotImplementedException();
        }

        public bool Validate<T>(T value)
        {
            throw new NotImplementedException();
        }
    }
}
