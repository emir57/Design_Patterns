using System;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAggregate aggregate = new EmployeeAggregate();
            aggregate.Add(new Employee { Id = 1, FirtsName = "Emir", LastName = "Gurbuz" });
        }
    }
}
