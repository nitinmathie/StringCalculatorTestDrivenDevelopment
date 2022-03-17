using System;
using NUnit.Framework;

namespace StringCalculatorTest
{
    public class Tests
    {
        [Test]
        public void Add_EmptyStringParameters_ReturnZero()
        {
            Assert.AreEqual(0, StringCalculatorTdd.Add(""));
        }
        [Test]
        public void Add_StringwithOneParameter_ReturnParameter()
        {
            Assert.AreEqual(5, StringCalculatorTdd.Add("5"));
        }
        [Test]
        public void Add_StringwithOneParameter_ReturnSameParameter()
        {
            Assert.AreEqual(6, StringCalculatorTdd.Add("6"));
        }
        [Test]
        public void Add_StringwithAlphabetAsParameter_ReturnException()
        {
            var ex = Assert.Throws<ArgumentException>(() => StringCalculatorTdd.Add("a"));
            Assert.That(ex.Message, Is.EqualTo("Invalid argument, please pass numbers only"));
        }
        [Test]
        public void Add_StringwithTwoParameters_ReturnSumOfParameters()
        {
            Assert.AreEqual(11, StringCalculatorTdd.Add("6,5"));
        }
        [Test]
        public void Add_StringwithTwoParameters_ReturnSumOfPassedParameters()
        {
            Assert.AreEqual(11, StringCalculatorTdd.Add("6,5"));
        }
        [Test]
        public void Add_StringwithThreeParameters_ReturnSumoftheThreeParameters()
        {
            Assert.AreEqual(24, StringCalculatorTdd.Add("7,8,9"));
        }
        [Test]
        public void Add_StringwithFourParameters_ReturnSumoftheFourParameters()
        {
            Assert.AreEqual(34, StringCalculatorTdd.Add("7,8,9,10"));
        }
        [Test]
        public void Add_StringwithAnyAmountOfParameters_ReturnSumoftheSpecifiedAmountOfParameters()
        {
            Assert.AreEqual(55, StringCalculatorTdd.Add("1,2,3,4,5,6,7,8,9,10"));
        }
        [Test]
        public void Add_StringwithUsersChoiceOfParametersAndNewLine_ReturnSumofUsersChoiceOfParameters()
        {
            Assert.AreEqual(70, StringCalculatorTdd.Add("7\n,8,9,10,11,12,13"));
        }
        [Test]
        public void Add_StringwithUsersChoiceOfParametersAndNewLineDelimitedByComma_ReturnSumofUsersChoiceOfParametersIgnoringNewLine()
        {
            Assert.AreEqual(70, StringCalculatorTdd.Add("7,\n,8,9,10,11,12,13"));
        }
        [Test]
        public void Add_StringwithUsersChoiceOfParametersAndNewLineDelimitedByCommaAsLastNumber_ReturnSumofUsersChoiceOfParametersIgnoringNewLine()
        {
            var ex = Assert.Throws<ArgumentException>(() => StringCalculatorTdd.Add("7,8,9,10,11,12,13,\n"));
            Assert.That(ex.Message, Is.EqualTo("Invalid argument, please pass numbers only"));
        }
        [Test]
        public void Add_StringwithUsersChoiceOfParametersDelimitedBySemiColon_ReturnSumofUsersChoiceOfParameters()
        {
            Assert.AreEqual(3, StringCalculatorTdd.Add("//;\n1;2"));
        }
        [Test]
        public void Add_StringwithUsersChoiceOfParametersDelimitedByColon_ReturnSumofUsersChoiceOfParameters()
        {
            Assert.AreEqual(3, StringCalculatorTdd.Add("//:\n1:2"));
        }
        [Test]
        public void Add_StringwithUsersChoiceOfParametersUserChoiceOfDelimiter_ReturnSumofUsersChoiceOfParameters()
        {
            Assert.AreEqual(15, StringCalculatorTdd.Add("//:\n1:2:3:4:5"));
        }

    }
}