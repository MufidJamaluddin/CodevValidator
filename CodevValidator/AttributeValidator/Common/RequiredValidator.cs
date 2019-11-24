using CodevValidator.Validation.Common;
using System;

namespace CodevValidator.AttributeValidator.Common
{
    [AttributeUsage(
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = false
    )]
    public class RequiredValidator : Attribute, IValidator
    {
        private readonly RequiredValidation validation = new RequiredValidation();

        public RequiredValidator(string FieldName)
        {
            this.validation.FieldName = FieldName;
        }

        public string FormatErrorMessage 
        { 
            set
            {
                this.validation.FormatErrorMessage = value;
            } 
        }

        public string GetErrorMessage()
        {
            return this.validation.GetErrorMessage();
        }

        public bool Validate<T>(T dataToValidate)
        {
            return this.validation.Validate(dataToValidate);
        }
    }
}
