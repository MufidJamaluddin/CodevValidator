using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.AttributeValidator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator.Common.Tests
{
    class RequiedModelTest
    {
        [RequiredValidator("PasarName")]
        public string Apa { get; set; }
    }


    [TestClass()]
    public class RequiredValidatorTests
    {
        private readonly Validator validator = new Validator();

        [TestMethod()]
        public void RequiredValidatorTest()
        {
            var model = new RequiedModelTest
            {
                Apa = "Pasar Jaya",
            };

            Assert.IsTrue(validator.Validate(model));

            model.Apa = "";

            Assert.IsFalse(validator.Validate(model));
        }

        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var model = new RequiedModelTest
            {
                Apa = "Pasar Jaya",
            };

            validator.Validate(model);
            Assert.AreEqual(validator.GetErrorMessages(), new List<string>());

            model.Apa = "";

            validator.Validate(model);
            Assert.AreEqual(1, validator.GetErrorMessages().Count);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var model = new RequiedModelTest
            {
                Apa = "Pasar Jaya",
            };

            Assert.IsTrue(validator.Validate(model));
            Assert.AreEqual(validator.GetErrorMessages(), new List<string>());

            model.Apa = "";

            Assert.IsFalse(validator.Validate(model));
            Assert.AreEqual(1, validator.GetErrorMessages().Count);
        }
    }
}