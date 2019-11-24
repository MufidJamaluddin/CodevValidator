using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator.Number
{
    [AttributeUsage(
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = false
    )]
    public class MaxValidator : Attribute, IValidator
    {
        public int Max { get; set; }

        public MaxValidator(int max)
        {
            this.Max = max;
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
