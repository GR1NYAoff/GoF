using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Logic
{
    internal class FordFiesta : IFamillyCar
    {
        public string DriveSafe()
        {
            return "Ford Fiesta driving SAFE";
        }
    }
}
