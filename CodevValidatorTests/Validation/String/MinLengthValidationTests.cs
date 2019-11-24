using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.Validation.String;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.Validation.String.Tests
{
    [TestClass()]
    public class MinLengthValidationTests
    {
        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var validation = new MinLengthValidation
            {
                FieldName = "PasarName",
                MinLength = 10,
                FormatErrorMessage = "The {0} field length is less than {1}",
            };

            validation.Validate("abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(validation.GetErrorMessage(), "The PasarName field length is less than 10");

            validation.Validate("abc");
            Assert.AreEqual(validation.GetErrorMessage(), null);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var validation = new MinLengthValidation
            {
                FieldName = "PasarName",
                MinLength = 10,
                FormatErrorMessage = "The {0} field length is less than {1}",
            };

            Assert.IsFalse(validation.Validate("abcdefghijklmnopqrstuvwxyz"));
            Assert.IsTrue(validation.Validate("abc"));
        }
    }
}