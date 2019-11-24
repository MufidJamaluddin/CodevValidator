namespace CodevValidator.Validation.String
{
    public class RegexValidation : IValidation
    {
        public string FieldName { get; set; }
        public string FormatErrorMessage { get; set; }

        public bool IsSuccess => throw new System.NotImplementedException();

        public string GetErrorMessage()
        {
            throw new System.NotImplementedException();
        }

        public bool Validate<T>(T value)
        {
            throw new System.NotImplementedException();
        }
    }
}
