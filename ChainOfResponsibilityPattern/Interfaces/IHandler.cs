using System.Collections.Generic;

namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        IList<string> Handle(IList<string> request);
    }
}
