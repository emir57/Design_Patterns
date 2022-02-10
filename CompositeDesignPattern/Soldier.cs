namespace CompositeDesignPattern
{
    abstract class Soldier
    {
        protected string _name;
        protected Rank _rank;
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
