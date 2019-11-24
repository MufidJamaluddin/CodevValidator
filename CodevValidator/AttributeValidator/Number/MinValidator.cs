using System;

namespace CodevValidator.AttributeValidator.Number
{
    [AttributeUsage(
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = false
    )]
    public class MinValidator : Attribute, IValidator
    {
        public int Min { get; set; }

        public MinValidator(int min)
        {
            this.Min = min;
        }

        public string GetErrorMessage()
        {
            throw new NotImplementedException();
        }

        public bool Validate<T>(T dataToValidate)
        {
            throw new NotImplementedException();
        }
    }
}
