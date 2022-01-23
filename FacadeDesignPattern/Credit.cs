using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Credit
    {
        public bool UseCreditStatus(Customer customer)
        {
            return true;
        }
    }
}
