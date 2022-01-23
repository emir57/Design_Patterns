using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Facade
    {
        private Bank _bank;
        private BaseBank _baseBank;
        private Credit _credit;
        public Facade()
        {
            _bank = new();
            _baseBank = new();
            _credit = new();
        }
        public void UseCredit(Customer customer,decimal quantityDemanded)
        {
            if (_baseBank.BlackListCheck(customer.IdentityNumber)
                && _credit.UseCreditStatus(customer))
            {
                _bank.UseCredit(customer, quantityDemanded);
                Console.WriteLine("Credit is use successful.");
            }
            
        }
    }
}
