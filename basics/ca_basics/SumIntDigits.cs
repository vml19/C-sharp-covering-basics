namespace ca_basics
{
    internal static class SumIntDigits
    {
        /// <summary>
        /// You are given a two-digit integer n. Return the sum of its digits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        internal static int Solution(int n)
        {
            if (n >= 10 && n <= 99)
            {
                var str = n.ToString().Select(c => c - 48).ToArray();
                return str.Sum();
            }
            return n;
        }
    }
}
