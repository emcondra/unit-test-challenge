using Moq;
using NUnit.Framework;

namespace UnitTestChallenge
{
    public class CandyCreatorShould
    {
        [Test]
        public void create_candy_with_dark_chocolate_and_10000_calories()
        {
            var candyStub = new Stub<Candy>();
            candyStub.Setup(c => c.Calories).Returns(10000);

            var candyCreatorStub = new Stub<CandyCreator>();

            candyCreatorStub.Setup(c => c.Candy).Returns(candyStub.Object);
            candyCreatorStub.Setup(c => c.Candy.TypeOfChocolate).Returns("dark"); 

            var candyCreator = candyCreatorStub.Object;

            Assert.AreEqual("dark", candyCreator.Candy.TypeOfChocolate);
            Assert.AreEqual(10000, candyCreator.Candy.Calories);
        }
    }
}
