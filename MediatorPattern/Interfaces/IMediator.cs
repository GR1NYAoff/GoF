namespace MediatorPattern.Interfaces
{
    internal interface IMediator
    {
        void Notify(object sender, string command);
    }
}
