using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            var customer = new Customer {
                Name = "Emir", IdentityNumber = "1231", CustomerNumber = 4926 };
            facade.UseCredit(customer, 4500);
        }
    }
}
