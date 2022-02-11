namespace StateDesignPattern
{
    public class NoCash : AtmState
    {
        public override void EjectCard(AtmMachine context)
        {
            System.Console.WriteLine("Para Yok");
        }

        public override void InsertCard(AtmMachine context)
        {
            System.Console.WriteLine("Para Yok");
        }

        public override void InsertPin(int pin, AtmMachine context)
        {
            System.Console.WriteLine("Para Yok");
        }

        public override void RequestCash(int cashToWithDraw, AtmMachine context)
        {
            System.Console.WriteLine("Para Yok");
        }
    }
}
