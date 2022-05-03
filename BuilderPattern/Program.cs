using System;

namespace BuilderPattern
{
    internal static class Program
    {
        private static void Main()
        {
            Builder concreteBuilder = new ConcreteBuilder();

            Director director = new Director(concreteBuilder);

            director.Construct();

            Product product = concreteBuilder.GetResult();

            Console.WriteLine(product);

            Console.ReadKey();
        }
    }
}
