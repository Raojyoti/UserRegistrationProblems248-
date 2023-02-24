using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblems;

namespace TestUserRegistration
{
    [TestClass]
    public class TestUserEntry
    {
        /// <summary>
        /// UC11-Test Validations for multiple entry for the Email Address.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="expected"></param>
        [TestMethod]
        public void TestValidationForEmailSamples()
        {
            string expected = "Valid";
            string[] input = { "abc@yahoo.com,", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc111@abc.com,", "abc-100@abc.net,", "abc.100@abc.com.au", "abc.100@abc.com.au", "abc@1.com,", "abc@gmail.com.com" };
            string pattern = @"^([a-z0-9\.\-]+)?@([a-z0-9]+)\.([a-z\,\.]+)$";
            Pattern pattern1 = new Pattern();
            foreach (string inputItem in input)
            {
                string actual = pattern1.ValidateUserDetails(inputItem, pattern);
                Assert.AreEqual(expected, actual);
            }
        }
        /// <summary>
        /// TC-RefactorCode12.1:- Throw custom exceptions in case of Invalid User Name.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("Jyoti", "^[A-Z]{1}[a-z]{2,}$", "Valid")]
        [DataRow(null, "^[A-Z]{1}[a-z]{2,}$", "Input is having null")]
        [DataRow("", "^[A-Z]{1}[a-z]{2,}$", "Input is having empty")]
        public void GiveInvalidUserNameShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                Pattern pattern1 = new Pattern();
                string actual = pattern1.ValidateUserDetails(input, pattern);
                Assert.AreEqual(expected, actual);
            }
            catch(CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// TC-RefactorCode12.2:- Throw custom exceptions in case of Invalid User Email Id.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Valid")]
        [DataRow(null, @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Input is having null")]
        [DataRow("", @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Input is having empty")]
        public void GiveInvalidUserEmailIdShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserDetails(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// TC-RefactorCode12.3:- Throw custom exceptions in case of Invalid Mobile Number.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("91 9919819801", "^[1-9]{2}?([ ])[0-9]{10}$", "Valid")]
        [DataRow(null, "^[1-9]{2}?([ ])[0-9]{10}$", "Input is having null")]
        [DataRow("", "^[1-9]{2}?([ ])[0-9]{10}$", "Input is having empty")]
        public void GiveInvalidMobileNumberShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserDetails(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// TC-RefactorCode12.4:- Throw custom exceptions in case of Invalid User Email Id.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("#Jyoti1rAO", "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Valid")]
        [DataRow(null, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Input is having null")]
        [DataRow("", "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Input is having empty")]
        public void GiveInvalidUserPasswordShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserDetails(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
