using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    abstract class AtmState
    {
        public abstract void InsertCard(AtmMachine contetx);
        public abstract void EjectCard(AtmMachine contetx);
        public abstract void InsertPin(int pin,AtmMachine contetx);
        public abstract void RequestCash(int cashToWithDraw,AtmMachine contetx);
    }
}
