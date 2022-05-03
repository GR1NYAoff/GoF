using System.Collections.Generic;
using ChainOfResponsibilityPattern.Interfaces;

namespace ChainOfResponsibilityPattern.Logic
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler nextInLine;

        public IHandler SetNext(IHandler handler)
        {
            nextInLine = handler;
            return handler;
        }

        public virtual IList<string> Handle(IList<string> request)
        {
            if (nextInLine != null)
            {
                return nextInLine.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
