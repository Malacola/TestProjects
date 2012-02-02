using System.Collections.Generic;

namespace TDD
{
    public interface IGrouper
    {
        IEnumerable<IEnumerable<Measurement>> Group(IList<Measurement> measurements);
    }
}