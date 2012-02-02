using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD.Tests
{
	public class SizeGrouper : IGrouper
	{
		private int groupSize;

		public SizeGrouper(int groupSize)
		{
			// TODO: Complete member initialization
			this.groupSize = groupSize;
		}

		public IEnumerable<IEnumerable<Measurement>> Group(IList<Measurement> measurements)
		{
			int total = 0;
			while (total < measurements.Count)
			{
				yield return measurements.Skip(total).Take(groupSize);
				total += groupSize;
			}
		}
	}
}
