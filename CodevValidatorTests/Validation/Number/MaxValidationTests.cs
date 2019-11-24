using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.Validation.Number;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.Validation.Number.Tests
{
    [TestClass()]
    public class MaxValidationTests
    {

        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var validation = new MaxValidation
            {
                FieldName = "PasarName",
                Max = 100,
                FormatErrorMessage = "Field {0} is more than {1}",
            };

            Assert.AreEqual(validation.Validate(9000), false);

            Assert.AreEqual(validation.GetErrorMessage(), "Field PasarName is less than 9000");
        }


        [TestMethod()]
        public void ValidateTest()
        {
            var validation = new MaxValidation
            {
                FieldName = "PasarName",
                Max = 100,
                FormatErrorMessage = "Field {0} is more than {1}",
            };

            Assert.IsTrue(validation.Validate(20));

            Assert.AreEqual(validation.GetErrorMessage(), "Field PasarName is less than 9000");
        }

    }
}