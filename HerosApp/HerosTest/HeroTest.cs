using System;
using Xunit;
using HerosLib;

namespace HerosTest
{
    public class HeroTest
    {
        Hero testHero = new Hero();
        [Theory]
        [InlineData("Unit testing god")]
        [InlineData("Flying")]
        [InlineData("Laser Eyes")]
        public void AddSuperPowerShouldAddSuperPower(string superPower)
        {
            
            // Act (Do the thing you wanna test)
            testHero.AddSuperPower(superPower);

            // Assert                              // Peek allows looking at top unit of a stack without Poping it off
            Assert.Equal(superPower, Hero.superPowers.Peek());

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddSuperPowerShouldThrowArgumentException(string superPower)
        {
            // Catching exceptions in unti tests
            Assert.Throws<ArgumentException>(() => testHero.AddSuperPower(superPower));
        }
    }
}
