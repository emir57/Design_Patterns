using System.Collections.Generic;

namespace IteratorDesignPattern
{
    class EmployeeAggregate : IAggregate
    {
        List<Employee> List = new List<Employee>();
        public void Add(Employee employee) => List.Add(employee);
        public Employee getItem(int index) => List[index];
        public int Count { get => List.Count; }
        public IIterator CreateIterator() => new EmployeeIterator(this);
    }
}
