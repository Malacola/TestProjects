using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD.Tests
{
	public class SizeGrouper
	{
		private int groupSize;

		public SizeGrouper(int groupSize)
		{
			// TODO: Complete member initialization
			this.groupSize = groupSize;
		}

		public IList<IList<Measurement>> Group(List<Measurement> measurements)
		{
			var result = new List<IList<Measurement>>();
			result.Add(measurements);
			return result;
		}
	}
}
