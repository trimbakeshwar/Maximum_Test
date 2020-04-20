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
            int numberOne = 5;
            int numberTwo = 10;
            int numberThree= 6;
            MaximumTest<int> test = new MaximumTest<int>(numberOne, numberTwo, numberThree);
            Assert.AreEqual(test.output, expected);

        }
        /// <summary>
        /// test for float value
        /// </summary>
        [Test]
        public void maxTestForFloat()
        {
            float expected = 6.75f;
            float numberOne = 5.25f;
            float numberTwo = 6.2f;
            float numberThree = 6.75f;
            MaximumTest<float> test = new MaximumTest<float>(numberOne, numberTwo, numberThree); 
            Assert.AreEqual(test.output, expected);

        }
        /// <summary>
        /// check for string 
        /// </summary>
        [Test]
        public void maxTestForString()
        {
            string expected = "anthani";
            string stringOne ="amar";
            string stringTwo = "akbar";
            string stringThree = "anthani";
            MaximumTest<string>test = new MaximumTest<string>(stringOne, stringTwo, stringThree);
            Assert.AreEqual(test.output, expected);

        }
       
    }
}