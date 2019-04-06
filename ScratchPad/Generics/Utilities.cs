using System;

namespace Generics

{
    //Possible constraints:
    // where T : IComparable    - interface
    // where T : Product        - specific class
    // where T : struct         - value type
    // where T : class          - reference type
    // where T : new()          - object with a default constructor

    //You can put a constraint on a class or on a method
    //  public T Max<T>(T a, T b) where T : IComparable 
    //  {
    //    return a.CompareTo(b) > 0 ? a : b;
    //  }

    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}