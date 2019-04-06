using System;

namespace Generics

{
    //Possible constraints:
    // where T : IComparable    - must implement a given interface
    // where T : Product        - must be of a given type or its subclasses
    // where T : struct         - must be a value type
    // where T : class          - must be a reference type
    // where T : new()          - must have a default constructor

    //You can put a constraint on a class or on a method
    //  public T Max<T>(T a, T b) where T : IComparable 
    //  {
    //    return a.CompareTo(b) > 0 ? a : b;
    //  }

    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}