using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordValidator.Tests
{
    [TestClass]
    public class PasswordValidatorTests
    {
        [TestMethod]
        public void hasUpper_returns_true_if_password_has_one_capital_letter()
        {
            // arrange
            var password = "Ab10";

            // act
            bool result = Program.hasUpper(password);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void hasUpper_returns_false_if_password_has_no_capital_letter()
        {
            // arrange
            var password = "asdf";

            // act
            bool result = Program.hasUpper(password);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void hasLower_returns_true_if_password_has_one_capital_letter()
        {
            // arrange
            var password = "adsf132SD";

            // act
            bool result = Program.hasLower(password);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void hasLower_returns_false_if_password_has_no_capital_letter()
        {
            // arrange
            var password = "SDSD23";

            // act
            bool result = Program.hasLower(password);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void hasNumber_returns_true_if_password_has_one_capital_letter()
        {
            // arrange
            var password = "adsf132SD";

            // act
            bool result = Program.hasNumber(password);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void hasNumber_returns_false_if_password_has_no_capital_letter()
        {
            // arrange
            var password = "SDSD";

            // act
            bool result = Program.hasNumber(password);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void checkLength_returns_true_if_password_length_is_greater_than_six()
        {
            // arrange
            var password = "asdfAAadf11";

            // act
            bool result = Program.lengthChecker(password);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkLength_returns_false_if_password_length_is_less_than_six()
        {
            // arrange
            var password = "asdfA";

            // act
            bool result = Program.lengthChecker(password);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void hasLetterOrDigit_returns_false_if_non_alphanumeric_password_supplied()
        {
            // arrange
            var password = "asdf_34sadfl;k";

            // act
            bool result = Program.hasLetterOrDigit(password);

            // assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void validator_returns_true_if_password_satisfy_all_rules()
        {
            // arrange
            var password = "AAbb11";

            // act
            bool result = Program.validator(password);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void validator_returns_false_if_password_doesnt_satisfy_all_rules()
        {
            // arrange
            var password = "bb11";

            // act
            bool result = Program.validator(password);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void validator_returns_false_if_password_contains_non_alphanumeric()
        {
            // arrange
            var password = "bb11_";

            // act
            bool result = Program.validator(password);

            // assert
            Assert.IsFalse(result);
        }
    }
}
