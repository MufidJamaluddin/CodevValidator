using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator
{
    public interface IValidator
    {
        bool Validate<T>(T dataToValidate);
        string GetErrorMessage();
    }
}
