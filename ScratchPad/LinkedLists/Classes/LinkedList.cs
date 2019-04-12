using System.Threading;

namespace LinkedLists.Classes
{
    public class LinkedList<T>
    {
        private Node<T> _head;
        public int Count { get; set; }

        public LinkedList()
        {
            Count = 0;
            _head = null;
        }

        public void Insert(T data)
        {
            var node = CreateNode(data);
            node.Next = _head;
            _head = node;
        }

        private Node<T> CreateNode(T data)
        {
            Count++;
            return new Node<T>
            {
                Data = data
            };
        }

        public T Get(int index)
        {
            var position = 0;
            Node<T> node = _head;
            while (position < index && node != null)
            {
                node = node.Next;
                position++;
            }

            return node != null ? node.Data : default;
        }
        private class Node<TData>
        {
            public TData Data;
            public Node<TData> Next;
        }
    }

}
