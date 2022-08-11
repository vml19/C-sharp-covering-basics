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

            //Console.WriteLine(SumIntDigits.Solution(59));
            //Console.WriteLine(Palindrome.Solution("abacaba"));
            //Console.WriteLine(ShapeArea.Solution(5));
            Console.WriteLine(MoneyChange.CountChange(10, new int[] { 1, 3, 4, 5}));    
        }
    }
}