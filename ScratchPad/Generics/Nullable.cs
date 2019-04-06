namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        public Nullable()
        {
            //default constructor in the event the value is not set
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; } //return true if we have a value
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value; //casting because _value is an object

            return default(T); 
        }
    }
}