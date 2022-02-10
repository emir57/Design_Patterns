namespace CompositeDesignPattern
{
    class BuckPrivate : Soldier
    {
        public BuckPrivate(string name,Rank rank):base(name,rank)
        {

        }
        public override void ExecuteOrder() 
            => System.Console.WriteLine($"{_rank} - {_name}");
    }
}
