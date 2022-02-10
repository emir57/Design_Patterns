using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    class Commander : SoldierComposite
    {
        List<Soldier> _soldiers = new List<Soldier>();
        public Commander(string name,Rank rank):base(name,rank)
        {

        }
        public override void AddSoldier(Soldier soldier) => _soldiers.Add(soldier);

        public override void ExecuteSoldier()
        {
            Console.WriteLine("{0} - {1}",_rank,_name);
            foreach (var soldier in _soldiers)
            {
                soldier.ExecuteSoldier();
            }
        }

        public override void RemoveSoldier(Soldier soldier) => _soldiers.Remove(soldier);
    }
}
