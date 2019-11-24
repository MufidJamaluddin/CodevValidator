using System;

namespace CodevValidator.Validation.Number
{
    public class MinValidation : IValidation
    {
        public string FieldName { get; set; }
        public string FormatErrorMessage { get;  set; }

        public int Min { get; set; }

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
