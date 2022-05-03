using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Logic
{
    internal class FordFactory : IVehicleFactory
    {
        public IFamillyCar CreateFamillyCar()
        {
            return new FordFiesta();
        }

        public ISportCar CreateSportCar()
        {
            return new FordMustang();
        }
    }
}
