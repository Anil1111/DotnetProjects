using System.Collections.Generic;

namespace GenBasic.Classes
{
    // Generic Default Values

    public class SimpleList<T>
    {
        private readonly List<T> _data = new List<T>();

        public void Add(T toAdd)
        {
            _data.Add(toAdd);
        }

        public T Get(int index)
        {
            if (index < 0 || index > _data.Count - 1)
            {
                return default; //return whatever the default is for T
            }
            return _data[index];
        }

    }
}
