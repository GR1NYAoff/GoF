namespace ObserverPattern.Interfaces
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
