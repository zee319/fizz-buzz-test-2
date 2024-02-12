using FizzBuzzTest_2.Services;

namespace FizzBuzzUnitTests
{
    public class FizzBuzzUnitTests
    {
        private FizzBuzzLogicService fizzBuzzLogicService;

        [SetUp]
        public void Setup()
        {
            fizzBuzzLogicService = new FizzBuzzLogicService();
        }

        [Test]
        public void WhenDivisibleByThreeShouldReturnFizz()
        {
            //Arrange
            int testNumber = 6;

            // Act
            string result = fizzBuzzLogicService.GetFizzBuzz(testNumber);

            // Assert
            Assert.That("Fizz" == result);
        }

        [Test]
        public void WhenDivisibleByFiveShouldReturnBuzz()
        {
            int testNumber = 10;

            string result = fizzBuzzLogicService.GetFizzBuzz(testNumber);

            Assert.That("Buzz" == result);
        }

        [Test]
        public void WhenDivisibleByFiveAndThreeShouldReturnFizzBuzz()
        {

            int testNumber = 15;

            string result = fizzBuzzLogicService.GetFizzBuzz(testNumber);

            Assert.That("FizzBuzz" == result);
        }

        [Test]
        public void WhenNumberIsNotDivisibleByFiveOrThreeShouldReturnNumber()
        {
            int testNumber = 11;

            string result = fizzBuzzLogicService.GetFizzBuzz(testNumber);

            Assert.That("11" == result);
        }
    }
}