using System;

namespace Iterators
{
    public interface IIterator<TValue>
    {
        TValue? Current { get; }  

        bool MoveNext();
    }
}
