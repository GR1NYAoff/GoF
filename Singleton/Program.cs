using System;

namespace SingletonPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
                s1.SomeBusinessLogic();
                s2.SomeBusinessLogic();
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.ReadKey();
        }
    }
}
