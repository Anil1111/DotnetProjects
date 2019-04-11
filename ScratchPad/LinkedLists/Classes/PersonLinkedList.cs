using System.Threading;

namespace LinkedLists.Classes
{
    //Non Generic LinkedList
    public class PersonLinkedList
    {
        private PersonNode _head;
        public int Count { get; set; }

        public PersonLinkedList()
        {
            Count = 0;
            _head = null;
        }


        public void Insert(Person data)
        {
            var node = CreateNode(data);
            node.Next = _head;
            _head = node;
        }
        private PersonNode CreateNode(Person data)
        {
            Count++;
            return new PersonNode {Data = data};
        }

        public Person Get(int index)
        {
            var position = 0;
            PersonNode node = _head;

            while (position < index && node != null)
            {
                node = node.Next;
                position++;
            }

            if (node != null)
            {
                return node.Data;
            }

            return null;

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class PersonNode
    {
        public Person Data;
        public PersonNode Next;
    }
}
