using System;

namespace TemplateMethodPattern.Logic
{
    internal class RedirectPayment : BasePayment
    {
        protected override void RedirectToGateway()
        {
            Console.WriteLine("Redirecting user to gateway");
        }
    }
}
