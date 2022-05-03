using System;
using StrategyPattern.Logic;

namespace StrategyPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new SortAsc());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new SortDesc());
            context.DoSomeBusinessLogic();
        }
    }
}
