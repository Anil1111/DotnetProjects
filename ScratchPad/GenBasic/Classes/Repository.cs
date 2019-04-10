using System.Collections.Generic;

namespace GenBasic.Classes
{
    public class Repository<T>
    {
        private readonly List<T> _data = new List<T>();

        public void Add(T toAdd)
        {
            _data.Add(toAdd);
        }

        public void Delete(T toDelete)
        {
            _data.Remove(toDelete);
        }

        public IEnumerable<T> All()             //get all
        {
            return _data;
        }

        public T Get(int index)                 //get an individual value from list
        {
            return _data[index];
        }
    }
}

