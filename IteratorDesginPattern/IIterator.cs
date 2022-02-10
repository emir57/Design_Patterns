namespace IteratorDesignPattern
{
    interface IIterator
    {
        bool HasItem();
        Employee NextItem();
        Employee CurrentItem();
    }
}
