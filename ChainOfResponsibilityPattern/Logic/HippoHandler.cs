using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern.Logic
{
    public class HippoHandler : AbstractHandler
    {
        public override IList<string> Handle(IList<string> request)
        {
            if (request.Contains("meat") || request.Contains("human"))
            {
                Console.WriteLine("Hippopotamus likes meat");
            }

            return base.Handle(request);
        }
    }
}
