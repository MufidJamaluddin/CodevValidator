using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.AttributeValidator.Number;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator.Number.Tests
{
    class MaxModelTest
    {
        [MaxValidator(100)]
        public int Nilai { get; set; }
    }


    [TestClass()]
    public class MaxValidatorTests
    {
        private readonly Validator validator = new Validator();

        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var model = new MaxModelTest
            {
                Nilai = 120,
            };

            Assert.IsInstanceOfType(validator.Validate(model), typeof(bool));
            Assert.IsFalse(validator.Validate(model));
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var model = new MaxModelTest
            {
                Nilai = 10,
            };

            Assert.IsTrue(validator.Validate(model));
        }
    }
}