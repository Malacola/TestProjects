using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests.AveragingCalculator_Tests.SadPath
{
	[TestClass]
	public class When_passing_null_measurements
	{
		private AveragingCalculator averagingCalculator;

		[TestInitialize]
		public void SetUp()
		{
			averagingCalculator = new AveragingCalculator();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void When_measurements_are_null()
		{
			averagingCalculator.Aggregate(null);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void When_measurement_is_null()
		{
			var measurements = Mother.Get4Measurements();
			measurements.Add(null);
			averagingCalculator.Aggregate(measurements);
		}
	}
}
