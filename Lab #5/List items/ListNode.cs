namespace List_items
{
    public class ListNode<ListDataType>
    {
        public ListDataType? Value;
        public ListNode<ListDataType>? Next { get; set; }
    }
}
