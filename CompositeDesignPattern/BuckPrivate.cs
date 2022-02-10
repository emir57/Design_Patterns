namespace CompositeDesignPattern
{
    class BuckPrivate : Soldier
    {
        public BuckPrivate(string name,Rank rank):base(name,rank)
        {

        }
        public override void AddSoldier(Soldier soldier)
        {
            throw new System.NotImplementedException();
        }

        public override void ExecuteSoldier() => System.Console.WriteLine($"{_rank} - {_name}");

        public override void RemoveSoldier(Soldier soldier)
        {
            throw new System.NotImplementedException();
        }
    }
}
