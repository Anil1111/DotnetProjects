namespace GenBasic.Classes
{
    public class NonGenericClass
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }
}
