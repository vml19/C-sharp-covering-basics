namespace extention_methods
{
    internal static class StringExtentionMethod
    {
        public static int ParseInt32(this string text)
        {
            return Int32.Parse(text);
        }
    }
}
