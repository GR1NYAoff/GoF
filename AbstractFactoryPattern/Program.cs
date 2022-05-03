using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Logic;
using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientMethod(new FordFactory());
            Console.WriteLine();
            ClientMethod(new OpelFactory());
        }

        public static void ClientMethod(IVehicleFactory factory)
        {
            var productA = factory.CreateFamillyCar();
            var productB = factory.CreateSportCar();

            Console.WriteLine(productA.DriveSafe());
            Console.WriteLine(productB.DriveFast());
        }
    }
}
