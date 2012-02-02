using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD
{
    public class AveragingCalculator : IAggregateCalculator
    {
        public Measurement Aggregate(IEnumerable<Measurement> measurements)
        {
            if (measurements.Contains(null))
                throw new ArgumentNullException();

            return new Measurement()
            {
                HighValue = measurements.Average(m => m.HighValue),
                LowValue = measurements.Average(m => m.LowValue)
            };
        }
    }
}