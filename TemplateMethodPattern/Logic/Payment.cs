namespace TemplateMethodPattern.Logic
{
    internal class Payment
    {
        public static void Process(BasePayment paymentFlow)
        {
            paymentFlow.ProcessPayment();
        }
    }
}
