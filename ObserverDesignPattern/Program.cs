using System;
using System.Collections.Generic;

namespace ObserverDesignPattern
{
    //Subject
    class Stock
    {
        public string Name { get; set; }
        private List<IFinancier> _financiers;
        private decimal _lotValue;
        public decimal LotValue
        {
            get { return _lotValue; }
            set
            {
                var isChange = false;
                if (_lotValue != value) isChange = true;
                _lotValue = value;
                if (isChange) Notify();
            }
        }
        private void Notify()
        {
            foreach (var financier in _financiers)
            {
                financier.Update(this);
            }
        }
        public Stock()
        {
            _financiers = new List<IFinancier>();
        }
        public void AddSubscribe(IFinancier financier)
        {
            _financiers.Add(financier);
        }
        public void UnSubscribe(IFinancier financier)
        {
            _financiers.Remove(financier);
        }
    }
    //Observer
    interface IFinancier
    {
        void Update(Stock stock);
    }
    //ConcreteObserver
    class Financier : IFinancier
    {
        public string Name { get; set; }
        public void Update(Stock stock)
        {
            Console.WriteLine("{0} is update lotValue ==> {1}",stock.Name,stock.LotValue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock() {Name="Azon Deim Kimya",LotValue=12.4M };
            stock.AddSubscribe(new Financier() {Name="X business" });
            stock.AddSubscribe(new Financier() { Name = "Y business" });
            Console.WriteLine("{0} ==> lot value {1}",stock.Name,stock.LotValue);
            stock.LotValue += 1.2M;
            Console.WriteLine("{0} ==> lot value {1}",stock.Name,stock.LotValue);
        }
    }
}
