using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator.String
{
    [AttributeUsage(
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = false
    )]
    public class MinLengthValidator : Attribute, IValidator
    {
        public int MinLength { get; set; }

        public MinLengthValidator(int minLength)
        {
            this.MinLength = minLength;
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
