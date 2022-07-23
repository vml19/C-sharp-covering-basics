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

            Console.WriteLine(SumIntDigits.Solution(59));
        }
    }
}