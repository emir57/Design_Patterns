using System;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAggregate aggregate = new EmployeeAggregate();
            aggregate.Add(new Employee { Id = 1, FirstName = "Emir", LastName = "Gurbuz" });
            aggregate.Add(new Employee { Id = 2, FirstName = "Kadir", LastName = "Cakmak" });
            aggregate.Add(new Employee { Id = 3, FirstName = "Süleyman", LastName = "Yaz" });

            IIterator iterator = aggregate.CreateIterator();
            while (iterator.HasItem())
            {
                Console.WriteLine("{0} - {1} {2}",iterator.CurrentItem().Id,iterator.CurrentItem().FirstName,iterator.CurrentItem().LastName);
                iterator.NextItem();
            }
        }
    }
}
