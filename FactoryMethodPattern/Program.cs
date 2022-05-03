using FactoryMethodPattern.Logic;
using System;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating vehicle with Ford Plant");
            ClientCode(new FordPlant());

            Console.WriteLine();

            Console.WriteLine("Creating vehicle with Opel Plant");
            ClientCode(new OpelPlant());
        }

        public static void ClientCode(VehiclePlant creator)
        {
            Console.WriteLine($"Client: I'm not aware of the car manufacture plant, but it still works.\n" + creator.CreateCar());
        }
    }
}
