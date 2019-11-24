namespace CodevValidator.Validation
{
    public interface IValidation
    {
        string FieldName { get; set; }
        string FormatErrorMessage { set; }
        bool IsSuccess { get; }
        bool Validate<T>(T value);
        string GetErrorMessage();
    }
}
