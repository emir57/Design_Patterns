using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new InterbaseFactory());
            factory.Start();
        }
    }
}
