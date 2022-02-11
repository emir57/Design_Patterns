using System;

namespace StateDesignPattern
{
    class NoCard : AtmState
    {
        public override void EjectCard(AtmMachine context)
        {
            Console.WriteLine("Kart Takılı Değil");
        }

        public override void InsertCard(AtmMachine context)
        {
            Console.WriteLine("Lütfen pin giriniz");
            context.State = new HasCard();
        }

        public override void InsertPin(int pin, AtmMachine context)
        {
            Console.WriteLine("Kart Takılı Değil");
        }

        public override void RequestCash(int cashToWithDraw, AtmMachine context)
        {
            Console.WriteLine("Kart Takılı Değil");
        }
    }
}
