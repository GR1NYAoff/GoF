using System;
using AdapterPattern.Interfaces;
using AdapterPattern.Logic;

namespace AdapterPattern
{
    internal static class Program
    {
        private static void Main()
        {
            Adaptee adaptee = new Adaptee();
            AdapteeSecond adapteeTwo = new AdapteeSecond();
            ITarget target = new Adapter(adaptee);
            ITarget targetTwo = new AdapterTwo(adapteeTwo);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
            Console.WriteLine(targetTwo.GetRequest());
        }
    }
}
