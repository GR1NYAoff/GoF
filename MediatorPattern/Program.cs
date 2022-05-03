using MediatorPattern.Logic;
using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new SpecificMediator();

            var handler = new Handler();

            mediator.Subscribe("test", handler);

            mediator.Notify("test");
        }
    }
}
