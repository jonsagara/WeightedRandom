using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using WeightedRandom;

namespace WeightedRandom.Tests
{
	public class WeightedRandomTests
	{
		[Fact]
		public void WeightedRandom_CreateWithTotalWeight100_Succeeds()
		{
			var items = new WeightedRandomItem<string>[]
			{
				new WeightedRandomItem<string>("A", 100)
			};

			Assert.DoesNotThrow(() => { new WeightedRandom<string>(items); });
		}
	}
}
