using DecoratorPattern;
using NUnit.Framework;

namespace DecoratorPatternTests
{
    public class DecoratorPatternTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanGetDescriptionOfBeverage()
        {
            // Arrange

            var houseBlend = new HouseBlend();

            // Act
            var description = houseBlend.Description;

            // Assert
            Assert.That(description, Is.EqualTo("House Blend"));
        }

        [Test]
        public void CanGetDescriptionOfHouseBlendMocha()
        {
            // Arrange

            var mocha = new Mocha(new HouseBlend());

            // Act
            var description = mocha.GetDescription();

            // Assert
            Assert.That(description, Is.EqualTo("House Blend, Mocha"));
        }

        [Test]
        public void CanCalculateCostOfHouseBlendWithMocha()
        {
            // Arrange

            var mocha = new Mocha(new HouseBlend());

            // Act
            var cost = mocha.CalculateCost();

            // Assert
            Assert.That(cost, Is.EqualTo(1.09d));
        }

        [Test]
        public void CanCalculateCostOfHouseBlendWithSoyAndMocha()
        {
            // Arrange
            var coffee = new Soy(new Mocha(new HouseBlend()));

            // Act
            var cost = coffee.CalculateCost();

            // Assert
            Assert.That(cost, Is.EqualTo(1.24));
        }

        [Test]
        public void CanGetDescriptionOfAHouseBlendWithMochAndSoy()
        {
            // Arrange
            var coffee = new Soy(new Mocha(new HouseBlend()));

            // Act
            var description = coffee.GetDescription();

            // Assert
            Assert.That(description, Is.EqualTo("House Blend, Mocha, Soy"));

        }
    }
}