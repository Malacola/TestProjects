using System.Collections.Generic;

namespace TDD
{
    public interface IAggregateCalculator
    {
        Measurement Aggregate(IEnumerable<Measurement> measurements);
    }
}