namespace StateDesignPattern
{
    public class HasCard : AtmState
    {
        public override void EjectCard(AtmMachine context)
        {
            System.Console.WriteLine("Kart başarıyla çıkartıldı.");
            context.State = new NoCard();
        }

        public override void InsertCard(AtmMachine context)
        {
            System.Console.WriteLine("Kart zaten takılı");
        }

        public override void InsertPin(int pin, AtmMachine context)
        {
            if(pin == 123)
            {
                System.Console.WriteLine("Pin Doğrulandı");
                context.CorrectPinEntered = true;
                context.State = new Haspin();
            }
        }

        public override void RequestCash(int cashToWithDraw, AtmMachine context)
        {
            System.Console.WriteLine("Lütfen önce pin giriniz");
        }
    }
}
