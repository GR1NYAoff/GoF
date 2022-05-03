using AdapterPattern.Interfaces;

namespace AdapterPattern.Logic
{
    public class AdapterTwo : ITarget
    {
        private readonly AdapteeSecond adaptee;

        public AdapterTwo(AdapteeSecond adaptee)
        {
            this.adaptee = adaptee;
        }

        public string GetRequest()
        {
            return "This is: " + adaptee.GetAnotherSpecificRequest();
        }
    }
}
