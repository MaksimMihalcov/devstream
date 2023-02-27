namespace ProblemSolving
{
    public static class StringExtension
    {
        public static string ReverseString(this string str)
        {
            return string.Join("", (new SortedSet<char>(str).Reverse()));
        }

        public static bool IsPalindrome(this string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
