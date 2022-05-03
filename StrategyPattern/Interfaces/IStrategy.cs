using System.Collections.Generic;

namespace StrategyPattern.Interfaces
{
    public interface IStrategy
    {
        IList<string> DoAlgorithm(IList<string> data);
    }
}
