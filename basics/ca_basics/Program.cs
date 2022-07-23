namespace ca_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine(SumIntDigits(59));
        }

        /// <summary>
        /// You are given a two-digit integer n. Return the sum of its digits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int SumIntDigits(int n)
        {
            if (n >= 10 && n <= 99)
            {
                var str = n.ToString().Select(c => c-48).ToArray();
                return str.Sum();
            }
            return n;
        }
    }
}