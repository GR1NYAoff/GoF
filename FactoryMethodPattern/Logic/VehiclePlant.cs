using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Logic
{
    internal abstract class VehiclePlant
    {
        public abstract IVehicle FactoryMethod();

        public string CreateCar()
        {
            var product = FactoryMethod();
            var result = $"Vehicle Plant: Here you go a new car. {product.Drive()}";
            return result;
        }
    }
}
