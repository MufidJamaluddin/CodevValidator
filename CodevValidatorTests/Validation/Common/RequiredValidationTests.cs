using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.Validation.Common.Tests
{
    [TestClass()]
    public class RequiredValidationTests
    {
        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var validation = new RequiredValidation
            {
                FieldName = "PasarName",
                FormatErrorMessage = "{0} is required",
            };

            validation.Validate<int?>(null);
            Assert.AreEqual(validation.FormatErrorMessage, "PasarName is required");

            validation.Validate<string>("");
            Assert.AreEqual(validation.FormatErrorMessage, "PasarName is required");

            validation.Validate<string>("Youauua");
            Assert.AreEqual(validation.FormatErrorMessage, null);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var validation = new RequiredValidation
            {
                FieldName = "PasarName",
                FormatErrorMessage = "{0} is required",
            };

            Assert.IsFalse(validation.Validate<int?>(null));
            Assert.IsFalse(validation.Validate<string>(""));
            Assert.IsTrue(validation.Validate<string>("Youauua"));
        }
    }
}