using System;

namespace ReversedString
{
    public static class StringReverseExtension
    {
        public static string Reverse(this string text)
        {
            var array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
