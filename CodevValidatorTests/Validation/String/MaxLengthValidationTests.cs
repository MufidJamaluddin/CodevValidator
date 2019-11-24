using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.Validation.String;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.Validation.String.Tests
{
    [TestClass()]
    public class MaxLengthValidationTests
    {
        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var validation = new MaxLengthValidation
            {
                FieldName = "PasarName",
                MaxLength = 10,
                FormatErrorMessage = "The {0} field length is more than {1}",
            };

            validation.Validate("abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(validation.GetErrorMessage(), "The PasarName field length is more than 10");

            validation.Validate("abc");
            Assert.AreEqual(validation.GetErrorMessage(), null);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var validation = new MaxLengthValidation
            {
                FieldName = "PasarName",
                MaxLength = 10,
                FormatErrorMessage = "The {0} field length is more than {1}",
            };

            Assert.IsFalse(validation.Validate("abcdefghijklmnopqrstuvwxyz"));
            Assert.IsTrue(validation.Validate("abc"));
        }
    }
}