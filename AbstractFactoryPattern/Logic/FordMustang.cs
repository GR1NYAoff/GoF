using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Logic
{
    internal class FordMustang : ISportCar
    {
        public string DriveFast()
        {
            return "Ford Mustang is damn fast";
        }
    }
}
