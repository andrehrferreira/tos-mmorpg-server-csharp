namespace Server
{
    public class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; } = null;

        public ListNode(T data)
        {
            Data = data;
        }
    }

    public class LinkedList<T>
    {
        private ListNode<T> head = null;

        public void Append(T data)
        {
            var newNode = new ListNode<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;

                while (current.Next != null)                
                    current = current.Next;
                
                current.Next = newNode;
            }
        }

        public void Prepend(T data)
        {
            var newNode = new ListNode<T>(data);
            newNode.Next = head;
            head = newNode;
        }

        public void Remove(T data)
        {
            if (head == null)
                return;

            if (head.Data.Equals(data))
            {
                head = head.Next;
                return;
            }

            var current = head;

            while (current.Next != null && !current.Next.Data.Equals(data))            
                current = current.Next;            

            if (current.Next != null && current.Next.Data.Equals(data))            
                current.Next = current.Next.Next;            
        }
    }
}
