using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD.Tests
{
	public static class Mother
	{
		public static IList<Measurement> Get4Measurements()
		{
            return new List<Measurement>
                       {
                           new Measurement() {HighValue = 10.0, LowValue = 1.0},
                           new Measurement() {HighValue = 5.0, LowValue = 2.0},
                           new Measurement() {HighValue = 2.0, LowValue = 1.0},
                           new Measurement() {HighValue = 10.0, LowValue = 4.0}
                       };
		}
	}
}
