namespace CompositeDesignPattern
{
    abstract class Soldier
    {
        private _name;
        private Rank _rank;
        public Soldier(string name,Rank rank)
        {
            _name = name;
            _rank = rank;
        }
        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
        public abstract void ExecuteSoldier();
    }
}
