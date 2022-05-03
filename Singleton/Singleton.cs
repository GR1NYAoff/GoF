using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Doing singleton logic from {0}", GetHashCode());
        }
    }

}
