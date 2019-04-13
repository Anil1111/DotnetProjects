using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace LinkedLists.Classes
{
    public class RemoveLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;

        public int Count { get; set; }

        public RemoveLinkedList()
        {
            Count = 0;
            _head = null;
        }

        public RemoveLinkedList(params T[] values) : this()
        {
            foreach (var value in values)
            {
                Insert(value);
            }
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

            if (node != null)
            {
                return node.Data;
            }

            return default;
        }

        private class Node<TData>
        {
            public TData Data;
            public Node<TData> Next;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void RemoveWhere(Func<T, bool> condition)
        {
            // remove all nodes at the beginning of the list meeting the condition
            while (_head != null && condition(_head.Data))
            {
                _head = _head.Next;
            }

            Node<T> node = _head;
            while (node != null)
            {
                // while the next node meets the criteria, forget it
                while (node.Next != null && condition(node.Next.Data))
                {
                    node.Next = node.Next.Next;
                }

                node = node.Next;
            }
        }
    }

}

