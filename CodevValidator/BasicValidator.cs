using CodevValidator.Validation;
using System.Collections.Generic;

namespace CodevValidator
{
    public class BasicValidator
    {
        public string FieldName { get; set; }
        public List<IValidation> ValidationTask { get; set; }

        protected List<string> messageError = new List<string>();
        public List<string> MessageError => messageError;

        public BasicValidator(string fieldName)
        {
            FieldName = fieldName;
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
