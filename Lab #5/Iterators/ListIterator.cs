using List_items;

namespace Iterators
{
    public class ListIterator<TValue> : IIterator<TValue>
    {
        private ListNode<TValue> _currentNode;
        
        public TValue? Current { get => _currentNode.Value; }
        
        public ListIterator(ListNode<TValue> startNode, bool reverse = false)
        {
            _currentNode = startNode;
        }

        public bool MoveNext()
        {
            if(_currentNode.Next is null)
            {
                return false;
            }
            _currentNode = _currentNode.Next;
            return _currentNode.Value is null ? MoveNext() : true;
        }
    }
}
