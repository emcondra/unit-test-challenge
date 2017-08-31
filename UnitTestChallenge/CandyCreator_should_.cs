using Moq;
using NUnit.Framework;

namespace UnitTestChallenge
{
    public class CandyCreatorShould
    {
        [Test]
        public void create_candy_with_dark_chocolate()
        {
            var candyStub = new Stub<Candy>();
            candyStub.Setup(c => c.Calories).Returns(100);

            var candyCreatorStub = new Stub<CandyCreator>();

            candyCreatorStub.Setup(c => c.Candy).Returns(candyStub.Object);
            candyCreatorStub.Setup(c => c.Candy.TypeOfChocolate).Returns("dark"); 

            var candyCreator = candyCreatorStub.Object;

            Assert.AreEqual("dark", candyCreator.Candy.TypeOfChocolate);
            Assert.AreEqual(100, candyCreator.Candy.Calories);
        }
    }
}
