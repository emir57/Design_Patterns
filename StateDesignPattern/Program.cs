using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmMachine atm = new AtmMachine();
            atm.InsertCard();
            atm.InsertPin(123);
            atm.RequestCash(500);
            atm.InsertCard();
            atm.InsertCard();
        }
    }
}
