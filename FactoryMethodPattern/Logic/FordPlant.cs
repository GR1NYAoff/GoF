using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Logic
{
    internal class FordPlant : VehiclePlant
    {
        public override IVehicle FactoryMethod()
        {
            return new Ford();
        }
    }
}
