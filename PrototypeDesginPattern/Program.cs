using System;
using System.Collections.Generic;

namespace PrototypeDesginPattern
{
    //Prototype
    abstract class AdventurePrototype
    {
        public abstract AdventurePrototype Clone();
    }
    class Product : AdventurePrototype
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
        public Product(int productID,string name,decimal listPrice)
        {
            ProductID = productID;
            Name = name;
            ListPrice = listPrice;
        }

        public override AdventurePrototype Clone()
        {
            return this.MemberwiseClone() as AdventurePrototype;
        }
    }
    class Adventure
    {
        public List<AdventurePrototype> Entities { get; set; }
        public Adventure()
        {
            Entities = new List<AdventurePrototype>();
        }
    }
    class Person : AdventurePrototype
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override AdventurePrototype Clone()
        {
            return this.MemberwiseClone() as AdventurePrototype;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adventure adventure = new Adventure();
            Product tv = new Product(1, "Arçelik", 4500);
            adventure.Entities.Add(tv);
            Person bill = new Person("bill");
            adventure.Entities.Add(bill);
            adventure.Entities.Add(tv.Clone() as Product);
            adventure.Entities.Add(bill.Clone() as Person);
        }
    }
}
