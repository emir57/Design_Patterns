namespace CompositeDesignPattern
{
    abstract class SoldierComposite : Soldier
    {
        public SoldierComposite(string name,Rank rank):base(name,rank)
        {

        }
        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
    }
}
