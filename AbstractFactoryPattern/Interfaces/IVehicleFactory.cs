namespace AbstractFactoryPattern.Interfaces
{
    internal interface IVehicleFactory
    {
        ISportCar CreateSportCar();

        IFamillyCar CreateFamillyCar();
    }
}
