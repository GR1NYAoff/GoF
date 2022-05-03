using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern.Logic
{
    public class DogHandler : AbstractHandler
    {
        public override IList<string> Handle(IList<string> request)
        {
            if (request.Contains("bone"))
            {
                Console.WriteLine("Dog likes bone");
            }
            else
            {
                SetNext(null);
            }

            return base.Handle(request);
        }
    }
}
