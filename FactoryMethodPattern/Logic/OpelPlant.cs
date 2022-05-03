using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Logic
{
    internal class OpelPlant : VehiclePlant
    {
        public override IVehicle FactoryMethod()
        {
            return new Seeport();
        }
    }
}
