using NUnit.Framework;

namespace WeightedRandom.Tests
{
    [TestFixture]
    public class WeightedRandomTests
    {
        [Test]
        public void WeightedRandom_CreateWithTotalWeight100_Succeeds()
        {
            var items = new[]
			{
				new WeightedRandomItem<string>("A", 100)
			};

            Assert.DoesNotThrow(() => { new WeightedRandom<string>(items); });
        }
    }
}
