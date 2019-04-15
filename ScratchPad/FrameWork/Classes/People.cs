using System.Collections;
using System.Collections.Generic;

namespace FrameWork.Classes
{
    public class People : IEnumerable<Person>
    {
        private readonly Person[] _people;

        public People(params Person[] people)
        {
            _people = people;
        }

        public IEnumerator<Person> GetEnumerator()
        {
           return ((IEnumerable<Person>) _people).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
