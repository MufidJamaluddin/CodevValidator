using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodevValidator.AttributeValidator.String;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodevValidator.AttributeValidator.String.Tests
{
    class RegexValidatorModelTest
    {
        [RegexValidator(@"/[\w._%+-]+@[\w.-]+\.[a-zA-Z]{2,4}/")]
        public string YourEmail { get; set; }
    }

    [TestClass()]
    public class RegexValidatorTests
    {
        private readonly Validator validator = new Validator();

        [TestMethod()]
        public void GetErrorMessageTest()
        {
            var model = new RegexValidatorModelTest
            {
                YourEmail = "yaoaiabab@bjkalglk@kjnjkiu",
            };

            Assert.IsInstanceOfType(validator.Validate(model), typeof(bool));
            Assert.AreEqual(1, validator.GetErrorMessages().Count);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            var model = new RegexValidatorModelTest
            {
                YourEmail = "yaoaiabab@yourdomain.com",
            };

            Assert.IsTrue(validator.Validate(model));

            model.YourEmail = "niugeiuhvrhbyfygmn";
            Assert.IsFalse(validator.Validate(model));
        }
    }
}