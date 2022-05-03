using System;
using System.Collections.Generic;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Logic
{
    public class SortAsc : IStrategy
    {
        public IList<string> DoAlgorithm(IList<string> data)
        {
            data = data ?? throw new ArgumentNullException(nameof(data));

            (data as List<string>)?.Sort();

            return data;
        }
    }
}
