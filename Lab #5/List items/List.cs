using Iterators;

namespace List_items
{
    public class List<ListDataType> : IIterable<ListDataType>
    {
        private ListNode<ListDataType>? _head;
        public int Count { get; private set; }

        public void Add(ListDataType? value)
        {
            if(_head is null)
            {
                _head = new ListNode<ListDataType>()
                {
                    Value = value,
                    Next = null,
                };
            }
            else
            {
                IIterator<ListDataType> iterator = new ListIterator<ListDataType>(_head);
                ListNode<ListDataType> keeper = _head;
                while(iterator.MoveNext())
                {
                    _head = _head.Next;
                }
                _head.Next = new ListNode<ListDataType>()
                {
                    Value = value,
                    Next = null
                };
                _head = keeper;
            }

            ++Count;
        }

        public void Reverse()
        {
            ListNode<ListDataType>? prev = null;
            ListNode<ListDataType>? current = _head;
            ListNode<ListDataType>? next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            _head = prev;
        }

        public IIterator<ListDataType> GetIterator()
        {
            return new ListIterator<ListDataType>(_head, false);
        }
    }
}
