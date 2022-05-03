using System;
using System.Collections.Generic;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Logic
{
    public class SortDesc : IStrategy
    {
        public IList<string> DoAlgorithm(IList<string> data)
        {
            data = data ?? throw new ArgumentNullException(nameof(data));

            (data as List<string>)?.Sort();
            (data as List<string>)?.Reverse();

            return data;
        }
    }
}
