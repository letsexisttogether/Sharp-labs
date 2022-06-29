using Iterators;

namespace List_items
{
    public interface IIterable <TValue>
    {
        IIterator<TValue> GetIterator();
    }
}
