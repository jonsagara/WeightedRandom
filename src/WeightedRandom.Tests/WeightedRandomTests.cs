using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using WeightedRandom;

namespace WeightedRandom.Tests
{
	[TestFixture]
	public class WeightedRandomTests
	{
		[Test]
		public void WeightedRandom_CreateWithTotalWeight100_Succeeds()
		{
			var items = new WeightedRandomItem<string>[]
			{
				new WeightedRandomItem<string>("A", 100)
			};

			Assert.DoesNotThrow(() => { new WeightedRandom<string>(items); }, "Total weights must add up to exactly 100");
		}
	}
}
