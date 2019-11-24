using System;

namespace CodevValidator.AttributeValidator.String
{
    [AttributeUsage(
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = false
    )]
    public class MaxLengthValidator : Attribute, IValidator
    {
        public int MaxLength { get; set; }
        public MaxLengthValidator(int maxLength)
        {
            this.MaxLength = maxLength;
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
