using NUnit.Framework;
using maximumThree;
namespace Tests
{
    public class Tests
    {
       MaximumTest test=new MaximumTest();

           [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void maxTestForInteger()
        {
            int expected = 10;
            int number1 = 5;
            int number2 = 10;
            int number3 = 6;
            int output = test.checkMaxForInteger(number1, number2, number3);
            Assert.AreEqual(output, expected);

        }
        [Test]
        public void maxTestForFloat()
        {
            float expected = 6.75f;
            float number1 = 5.25f;
            float number2 = 6.25f;
            float number3 = 6.75f;
            float output = test.checkMaxForFloat(number1, number2, number3);
            Assert.AreEqual(output, expected);

        }
    }
}