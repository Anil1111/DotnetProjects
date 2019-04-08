using System;
using System.Linq;

namespace Extension.Classes
{
    public static class StringExtension
    {
        public static string Shorten(this string str, int numOfWords)
        {
            if (numOfWords < 0)
                throw new ArgumentOutOfRangeException(nameof(str));
            if (numOfWords == 0)
                return "";

            var words = str.Split(' ');
            return words.Length <= numOfWords ? str : string.Join(" ", words.Take(numOfWords)) + "...";
        }

        public static string ReverseAString(this string str)
        {
            if (str.Length < 0)
                return new InvalidOperationException(nameof(str)).ToString();
            if (str.Length == 0)
                return "";

            var tempArray = str.ToCharArray();
            Array.Reverse(tempArray);
            return new string(tempArray);
        }
    }
}
