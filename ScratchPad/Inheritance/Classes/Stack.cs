using System;
using System.Collections;

namespace Inheritance.Classes
{
    public class Stack
    {
        private readonly ArrayList _list = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Objects cannot be null");
            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            var objToDelete = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return objToDelete;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
