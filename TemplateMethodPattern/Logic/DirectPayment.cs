using System;

namespace TemplateMethodPattern.Logic
{
    internal class DirectPayment : BasePayment
    {
        protected override void ProcessNotification()
        {
            Console.WriteLine("Processing notification from gateway");
        }
    }
}
