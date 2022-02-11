namespace StateDesignPattern
{
    public class AtmMachine
    {
        AtmState state = new NoCard();
        public AtmState State { set { state = value; } }
        public int CashToMachine { get; set; } = 2000;
        public bool CorrectPinEntered { get; set; } = false;
        public void InsertCard() => state.InsertCard(this);
        public void EjectCard() => state.EjectCard(this);
        public void InsertPin(int pin) => state.InsertPin(pin, this);
        public void RequestCash(int cashToWithDraw) => state.RequestCash(cashToWithDraw, this);

    }
}
