using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Logic
{
    internal class OpelCorsa : ISportCar
    {
        public string DriveFast()
        {
            return "Opel Corsa is damn fast";
        }
    }
}
