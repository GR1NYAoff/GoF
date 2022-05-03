using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Logic
{
    internal class MonkeyHandler : AbstractHandler
    {
        public override IList<string> Handle(IList<string> request)
        {
            if (request.Contains("banana"))
            {
                Console.WriteLine("Monkey like eat bananas");
            }
            return base.Handle(request);
        }
    }
}
