using MediatorPattern.Interfaces;
using System;

namespace MediatorPattern.Logic
{
    internal class Handler : IHandler
    {
        public void DoWork()
        {
            Console.WriteLine("Work");
        }
    }
}
