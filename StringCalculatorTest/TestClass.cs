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
    
    }
}