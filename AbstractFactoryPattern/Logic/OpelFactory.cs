using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Logic
{
    internal class OpelFactory : IVehicleFactory
    {
        public IFamillyCar CreateFamillyCar()
        {
            return new OpelAstra();
        }

        public ISportCar CreateSportCar()
        {
            return new OpelCorsa();
        }
    }
}
