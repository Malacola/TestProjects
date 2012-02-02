using System.Collections.Generic;

namespace TDD
{
    public class MeasurementAggregator
    {
        private readonly IList<Measurement> _measurements;

        public MeasurementAggregator(IList<Measurement> measurements)
        {
            _measurements = measurements;
        }

        public IEnumerable<Measurement> Aggregate(IGrouper grouper,
                                                  IAggregateCalculator calculator)
        {
            var partitions = grouper.Group(_measurements);
            foreach (var partition in partitions)
            {
                yield return calculator.Aggregate(partition);
            }
        }
    }
}