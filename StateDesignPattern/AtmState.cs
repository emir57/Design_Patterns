using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public abstract class AtmState
    {
        public abstract void InsertCard(AtmMachine context);
        public abstract void EjectCard(AtmMachine context);
        public abstract void InsertPin(int pin,AtmMachine context);
        public abstract void RequestCash(int cashToWithDraw,AtmMachine context);
    }
}
