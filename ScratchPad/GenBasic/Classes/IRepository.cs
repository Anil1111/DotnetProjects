using System.Collections.Generic;

namespace GenBasic.Classes
{
    public interface IRepository <T>
    {
        void Add(T toAdd);
        void Delete(T toDelete);
        IEnumerable<T> All();
        T Get(int index);
    }
}
