using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests.AveragingCalculator_Tests
{
	[TestClass]
	public class When_averaging_four_numbers
	{
		private AveragingCalculator averagingCalculator;
		private IList<Measurement> measurements;
		private Measurement result;

		[TestInitialize]
		public void SetupTest()
		{
			averagingCalculator = new AveragingCalculator();
			measurements = Mother.Get4Measurements();
			result = averagingCalculator.Aggregate(measurements);
		}

		[TestMethod]
		public void then_the_high_average_is_correct()
		{
			var expectedAverage = AverageHigh(measurements);
			Assert.AreEqual(expectedAverage, result.HighValue);
		}

		[TestMethod]
		public void then_the_low_average_is_correct()
		{
			var expectedAverage = LowAverage(measurements);
			Assert.AreEqual(expectedAverage, result.LowValue);
		}

		private object LowAverage(IList<Measurement> measurements)
		{
			return measurements.Sum(m => m.LowValue) / measurements.Count;
		}

		private double AverageHigh(IList<Measurement> measurements)
		{
			return measurements.Sum(m => m.HighValue) / measurements.Count;
		}
	}
}
