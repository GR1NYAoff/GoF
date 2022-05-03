using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Logic
{
    internal class OpelAstra : IFamillyCar
    {
        public string DriveSafe()
        {
            return "Opel Astra driving SAFE";
        }
    }
}
