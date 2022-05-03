using System;
using TemplateMethodPattern.Logic;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Processing direct payment");

            Payment.Process(new DirectPayment());

            Console.Write("\n");
            Console.WriteLine("Processing redirect payment");

            Payment.Process(new RedirectPayment());
        }
    }
}
