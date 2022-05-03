using System;
using System.Collections.Generic;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Logic
{
    public class Context
    {
        private IStrategy strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy");

            var result = strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });
            var resultStr = string.Empty;

            foreach (var element in result)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
