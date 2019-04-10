using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GenBasic.Classes
{
    public class TyperInference
    {
        public static void Swap<T>(ref T first, ref T seccond)
        {
            T temp = first;
            first = seccond;
            seccond = temp;
        }

        public static T Deserialize<T>(Stream stream)
        {
            var formatter = new BinaryFormatter();
            return (T) formatter.Deserialize(stream);
        }
    }
}
