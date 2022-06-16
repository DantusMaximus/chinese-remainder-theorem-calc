using NUnit.Framework;
using KinesiskaRestsatsen;
namespace Testing
{
    public class GeneratedCongruenceSystemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThrowsWhenNoCongruenceSystemCanBeCreatedWithTheGivenInputs()
        {
            int maxValue = 100;
            int congs = 26;
            Assert.Throws(typeof(System.Exception), delegate{new GeneratedCongruenceSystem((maxValue, congs));} );
        }
    }
}