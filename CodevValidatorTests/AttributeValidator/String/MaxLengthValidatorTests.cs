using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.AttributeValidator.String;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator.String.Tests
{
    class ModelMaxLengthTest
    {
        [MaxLengthValidator(10)]
        public string AbapDev { get; set; }
    }

    [TestClass()]
    public class MaxLengthValidatorTests
    {
        private readonly Validator validator = new Validator();

        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var model = new ModelMaxLengthTest
            {
                AbapDev = "Mufid Jamaluddin",
            };

            Assert.IsInstanceOfType(validator.Validate(model), typeof(bool));
            Assert.AreEqual(1, validator.GetErrorMessages().Count);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var model = new ModelMaxLengthTest
            {
                AbapDev = "Mufid",
            };

            Assert.IsTrue(validator.Validate(model));
        }
    }
}