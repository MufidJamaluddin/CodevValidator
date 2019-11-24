using CodevValidator.AttributeValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CodevValidator
{
    public class Validator
    {
        private List<string> messages = null;

        public List<string> GetErrorMessages()
        {
            return messages;
        }

        public bool Validate<T>(T objectToValidate)
        {
            Type type = typeof(T);
            this.messages = new List<string>();
            bool success = true;

            var listType = new List<MethodInfo>(type.GetMethods());

            listType?.ForEach(methodInfo =>
            {
                var attributes = methodInfo.GetCustomAttributes(true)?
                    .Where(attribute => attribute is IValidator)
                    .Select(attribute => attribute as IValidator)
                    .ToList();

                attributes?.ForEach(attribute =>
                {
                    success = success && attribute.Validate(methodInfo.Invoke(objectToValidate, null));

                    if (attribute is AttributeMultipleValidator)
                    {
                        var attr = attribute as AttributeMultipleValidator;
                        this.messages.AddRange(attr.MessageError);
                    }
                    else
                    {
                        this.messages.Add(attribute.GetErrorMessage());
                    }
                });

            });

            return success;
        }
    }
}
