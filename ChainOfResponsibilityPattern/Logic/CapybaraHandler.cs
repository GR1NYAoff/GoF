using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern.Logic
{
    public class CapybaraHandler : AbstractHandler
    {
        public override IList<string> Handle(IList<string> request)
        {
            if (request.Contains("grass"))
            {
                Console.WriteLine("Capybara likes grass");
            }

            return base.Handle(request);
        }
    }
}
