using NUnit.Framework;
using maximumThree;
namespace Tests
{
    public class Tests
    {
      

           [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// check for integer
        /// </summary>
        [Test]
        public void maxTestForInteger()
        {
            int expected = 10;
            int number1 = 5;
            int number2 = 10;
            int number3 = 6;
            MaximumTest<int> test = new MaximumTest<int>(number1, number2, number3);
            Assert.AreEqual(test.output, expected);

        }
        /// <summary>
        /// test for float value
        /// </summary>
        [Test]
        public void maxTestForFloat()
        {
            float expected = 6.75f;
            float number1 = 5.25f;
            float number2 = 6.25f;
            float number3 = 6.75f;
            MaximumTest<float> test = new MaximumTest<float>(number1, number2, number3); 
            Assert.AreEqual(test.output, expected);

        }
        /// <summary>
        /// check for string 
        /// </summary>
        [Test]
        public void maxTestForString()
        {
            string expected = "anthani";
            string string1 ="amar";
            string string2 = "akbar";
            string string3 = "anthani";
            MaximumTest<string>test = new MaximumTest<string>(string1, string2, string3);
            Assert.AreEqual(test.output, expected);

        }
    }
}