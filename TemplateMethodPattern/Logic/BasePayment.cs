using System;

namespace TemplateMethodPattern.Logic
{
    public abstract class BasePayment
    {
        public void ProcessPayment()
        {
            GetUserCredentials();
            SendDataToGateway();
            RedirectToGateway();
            ProcessNotification();
            ShowFinalPage();
        }

        protected void ShowFinalPage()
        {
            Console.WriteLine("5. Showing to user finalpage");
        }

        protected virtual void ProcessNotification()
        {
            //do nothing here, needs to be overriden in proper implementation
        }

        protected virtual void RedirectToGateway()
        {
            //do nothing here, needs to be overriden in proper implementation
        }

        protected void SendDataToGateway()
        {
            Console.WriteLine("2. Sending order data to gateway");
        }

        protected void GetUserCredentials()
        {
            Console.WriteLine("1. Requesting credentials from user");
        }
    }
}
