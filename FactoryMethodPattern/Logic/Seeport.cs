using FactoryMethodPattern.Interfaces;
using System;

namespace FactoryMethodPattern.Logic
{
    internal class Seeport : IVehicle
    {
        public string Drive()
        {
            return $"Driving {this.GetType().Name} is cool";
        }
    }
}
