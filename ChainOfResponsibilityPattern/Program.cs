using System;
using System.Collections.Generic;
using ChainOfResponsibilityPattern.Logic;

namespace ChainOfResponsibilityPattern
{
    static class Program
    {
        static void Main()
        {
            var capybara = new CapybaraHandler();
            var hippo = new HippoHandler();
            var dog = new DogHandler();
            var monkey = new MonkeyHandler();

            hippo.SetNext(dog).SetNext(capybara).SetNext(monkey);

            var treats = new List<string>();
            treats.Add("grass");
            treats.Add("apple");
            treats.Add("human");
            treats.Add("bone");
            treats.Add("banana");

            hippo.Handle(treats);

            Console.ReadKey();
        }
    }
}
