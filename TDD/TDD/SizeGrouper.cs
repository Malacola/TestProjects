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
			int total = 0;
			while (total < measurements.Count)
			{
				var group = measurements.Skip(total).Take(groupSize).ToList();
				result.Add(group);
				total += groupSize;
			}
			return result;
		}
	}
}
