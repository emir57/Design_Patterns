namespace StateDesignPattern
{
    class Haspin : AtmState
    {
        public override void EjectCard(AtmMachine context)
        {
            System.Console.WriteLine("Kart başarıyla çıakrtıldı");
            context.State = new NoCard();
        }

        public override void InsertCard(AtmMachine context)
        {
            System.Console.WriteLine("Kart zaten takılı");
        }

        public override void InsertPin(int pin, AtmMachine context)
        {
            System.Console.WriteLine("Pin zaten girilmiş");
        }

        public override void RequestCash(int cashToWithDraw, AtmMachine context)
        {
            if(cashToWithDraw > context.CashToMachine)
            {
                System.Console.WriteLine("Atm de yeterli bakiye yok işlem sonlandırlıyor");
                System.Console.WriteLine("Kart çıkartılmıştır");
                context.State = new NoCard();
            }
            else
            {
                System.Console.WriteLine("{0} tutarında para çekilmiştir",cashToWithDraw);
                context.CashToMachine -= cashToWithDraw;
                System.Console.WriteLine("Kart çıkartılmıştır");
                context.State = new NoCard();
                System.Console.WriteLine("{0} makinede kalan para",context.CashToMachine);
                if (context.CashToMachine <= 0)
                    context.State = new NoCash();
            }
        }
    }
}
