namespace IteratorDesignPattern
{
    class EmployeeIterator : IIterator
    {
        EmployeeAggregate _aggregate;
        int currentIndex;
        public EmployeeIterator(EmployeeAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        public Employee CurrentItem()
        {
            return _aggregate.getItem(currentIndex);
        }

        public bool HasItem()
        {
            if (currentIndex < _aggregate.Count)
                return true;
            return false;
        }

        public Employee NextItem()
        {
            if (HasItem())
                return _aggregate.getItem(currentIndex++);
            return new Employee();
        }
    }
}
