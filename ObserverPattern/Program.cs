using ObserverPattern.Logic;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerA);
            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.ReadKey();
        }
    }
}
