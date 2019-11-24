using CodevValidator.AttributeValidator;
using CodevValidator.Validation;
using System;
using System.Collections.Generic;

namespace CodevValidator
{
    [AttributeUsage(
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = false
    )]
    public class AttributeMultipleValidator : Attribute, IValidator
    {
        public string FieldName { get; set; }

        public List<string> MessageError => new List<string>();

        public List<IValidation> ValidationTask { get; set; }

        public string GetErrorMessage()
        {
            return string.Join(", ", this.MessageError.ToArray());
        }

        public bool Validate<T>(T value)
        {
            bool sucess = true;

            ValidationTask?.ForEach(item =>
            {
                if (!item.Validate(value))
                {
                    sucess = false;

                    MessageError.Add(item.GetErrorMessage());
                }
            });

            return sucess;
        }
    }
}
