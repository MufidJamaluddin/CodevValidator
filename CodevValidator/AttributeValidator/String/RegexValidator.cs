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
    public class RegexValidator : Attribute, IValidator
    {
        public string Regex { get; set; }
        public RegexValidator(string regEx)
        {
            this.Regex = regEx;
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
