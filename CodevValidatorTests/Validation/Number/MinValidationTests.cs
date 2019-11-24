using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.Validation.Number;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.Validation.Number.Tests
{
    [TestClass()]
    public class MinValidationTests
    {
        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var validation = new MinValidation
            {
                FieldName = "PasarName",
                Min = 100,
                FormatErrorMessage = "Field {0} is less than {1}",
            };

            Assert.IsFalse(validation.Validate(-2286));

            Assert.AreEqual(validation.GetErrorMessage(), "Field PasarName is less than 100");
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var validation = new MinValidation
            {
                FieldName = "PasarName",
                Min = 100,
                FormatErrorMessage = "Field {0} is less than {1}",
            };

            Assert.IsTrue(validation.Validate(2286));
            Assert.IsTrue(validation.Validate(3200));
            Assert.IsTrue(validation.Validate(4176));
            Assert.IsTrue(validation.Validate(5120));
            Assert.IsTrue(validation.Validate(6165));
            Assert.IsTrue(validation.Validate(7206));
            Assert.IsTrue(validation.Validate(875));
            Assert.IsTrue(validation.Validate(9129));
            Assert.IsTrue(validation.Validate(10109));
        }
    }
}