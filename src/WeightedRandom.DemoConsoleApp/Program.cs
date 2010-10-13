using System;

namespace WeightedRandom.DemoConsoleApp
{
	class Program
	{
		private static void Main(string[] args)
		{
			#region Inconsequential locals
			const string id1 = "A";
			const string id2 = "B";
			const string id3 = "C";
			const int weight1 = 10;
			const int weight2 = 50;
			const int weight3 = 40;

			const int numIterations = 100000;

			string id = null;
			int id1Returned = 0;
			int id2Returned = 0;
			int id3Returned = 0;
			#endregion


			//
			// Initialize an instance of WeightedRandom with an array of WeightedRandomItems.
			//

			var items = new WeightedRandomItem<string>[]
			{
				new WeightedRandomItem<string> (id1, weight1),
				new WeightedRandomItem<string> (id2, weight2),
				new WeightedRandomItem<string> (id3, weight3)
			};

			var weightedRandom = new WeightedRandom<string>(items);


			//
			// Call weightedRandom.Next() a bunch of times to demonstrate that, over time, the 
			//  items are returned according to their weighted distribution.
			//

			for (int ix = 0; ix < numIterations; ix++)
			{
				id = weightedRandom.Next();

				if (id1.Equals(id, StringComparison.OrdinalIgnoreCase))
					id1Returned++;
				else if (id2.Equals(id, StringComparison.OrdinalIgnoreCase))
					id2Returned++;
				else if (id3.Equals(id, StringComparison.OrdinalIgnoreCase))
					id3Returned++;
				else
					throw new Exception("An ID was returned from WeightedRandom.Next() that should not have been: " + id);
			}


			//
			// Display the results.
			//

			Console.WriteLine("Number of iterations: {0}", numIterations);
			Console.WriteLine("\t{0} selected {1} times, or {2}% of the time (weight: {3})", id1, id1Returned, Percentage(id1Returned, numIterations), weight1);
			Console.WriteLine("\t{0} selected {1} times, or {2}% of the time (weight: {3})", id2, id2Returned, Percentage(id2Returned, numIterations), weight2);
			Console.WriteLine("\t{0} selected {1} times, or {2}% of the time (weight: {3})", id3, id3Returned, Percentage(id3Returned, numIterations), weight3);
			Console.WriteLine("Number of selections: {0}", id1Returned + id2Returned + id3Returned);


			Console.WriteLine("Press ENTER to quit the application");
			Console.ReadLine();
		}

		private static string Percentage(int val1, int val2)
		{
			double fraction = (double) val1 / val2;
			return Convert.ToInt32(fraction * 100.0).ToString();
		}
	}
}
