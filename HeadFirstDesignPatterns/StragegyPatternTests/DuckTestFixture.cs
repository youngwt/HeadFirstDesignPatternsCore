using NUnit.Framework;
using StrategyPattern;
using StrategyPattern.Behaviours;

namespace StragegyPatternTests
{
    [TestFixture]
    public class DuckTestFixture
    {

        [Test]
        public void Mallard_can_quack()
        {
            // Arrange

            var duckUnderTest = new Mallard();

            // Act
            var result = duckUnderTest.Quack();


            // Asset
            Assert.That(result, Is.EqualTo("Quack!"));
        }

        [Test]
        public void Mallard_can_change_quack_to_muted()
        {
            // Arrange
            var duckUnderTest = new Mallard();
            duckUnderTest.QuackBehaviour = new MutedQuack();

            // Act
            var result = duckUnderTest.Quack();


            // Assert
            Assert.That(result, Is.EqualTo("..."));
        }
    }
}