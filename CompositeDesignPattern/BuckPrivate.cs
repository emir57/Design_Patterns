namespace CompositeDesignPattern
{
    class BuckPrivate : Soldier
    {
        public BuckPrivate(string name,Rank rank):base(name,rank)
        {

        }

        public override void ExecuteSoldier() 
            => System.Console.WriteLine($"{_rank} - {_name}");
    }
}
