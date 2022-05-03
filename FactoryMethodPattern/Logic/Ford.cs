using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Logic
{
    internal class Ford : IVehicle
    {
        public string Drive()
        {
            return "Driving Ford is better than cool";
        }
    }
}
