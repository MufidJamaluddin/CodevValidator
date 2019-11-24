using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.AttributeValidator.Number;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator.Number.Tests
{
    class MinModelTest
    {
        [MinValidator(0)]
        public int Nilai { get; set; }
    }

    [TestClass()]
    public class MinValidatorTests
    {
        private readonly Validator validator = new Validator();

        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var model = new MinModelTest
            {
                Nilai = 120,
            };

            Assert.IsInstanceOfType(validator.Validate(model), typeof(bool));
            Assert.IsFalse(validator.Validate(model));
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var model = new MinModelTest
            {
                Nilai = 10,
            };

            Assert.IsTrue(validator.Validate(model));
        }
    }
}