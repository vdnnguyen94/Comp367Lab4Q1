namespace StringUtilities
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string str)
        {
            return !string.IsNullOrEmpty(str) && char.IsUpper(str[0]);
        }
    }
}
