using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblems;

namespace TestUserRegistration
{
    [TestClass]
    public class TestUserEntry
    {
        /// <summary>
        /// TC1-First name starts with Capital and has minimum 3 characters
        /// TC2-Last name starts with Capital and has minimum 3 characters
        /// TC3-Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions
        /// TC4-Country code follow by space and 10 digit number.
        /// TC5-Password Validation.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("Jyoti", "^[A-Z]{1}[a-z]{2,}$", "Valid")]
        [DataRow("Rao", "^[A-Z]{1}[a-z]{2,}$", "Valid")]
        [DataRow("abc.xyz@bl.co.in", @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Valid")]
        [DataRow("91 9919819801", "^[1-9]{2}?([ ])[0-9]{10}$", "Valid")]
        [DataRow("#Jyoti1rAO", "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Valid")]
        public void TestValidationForUserEntries(string input, string pattern,string expected)
        {
            //Arrange
            Pattern pattern1 = new Pattern();
            //Act
            string actual= pattern1.ValidateUserEntry(input, pattern);
            //Assert
            Assert.AreEqual(expected,actual);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="expected"></param>
        [TestMethod]
        public void TestValidationForEmailSamples()
        {
            //Arrange
            string[] input = { "abc@yahoo.com,", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc111@abc.com,", "abc-100@abc.net,", "abc.100@abc.com.au", "abc.100@abc.com.au", "abc@1.com,", "abc@gmail.com.com" };
            string pattern = @"^([a-z0-9\.\-]+)?@([a-z0-9]+)\.([a-z\,\.]+)$";
            string expected = "Valid";
            Pattern pattern1 = new Pattern();
            foreach (string inputItem in input)
            {
                //Act
                string actual = pattern1.ValidateUserEntry(inputItem, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
