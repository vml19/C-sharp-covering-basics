namespace code_challenges
{
    internal class StaticPerson
    {
        public static int StaticAge = 0;
        public string Name = "";

        //Changed from only within instance constructor
        public readonly double ReadOnlyAccountBalance = 0;

        //Changed from only within static constructor
        public static readonly decimal StaticReadOnlyLoanAmount = 0;

        static StaticPerson()
        {
            Console.WriteLine($"Calling static constructor.");

            Console.WriteLine($"Increasing {nameof(StaticAge)} in the static constructor.");
            //Age will be increased for every new objects of this class
            StaticAge += 1;

            Console.WriteLine($"Increasing {nameof(StaticReadOnlyLoanAmount)} in the static constructor.");
            StaticReadOnlyLoanAmount += 1;

            Console.WriteLine($"Age: {StaticAge}, Loan amount: {StaticReadOnlyLoanAmount}");

            Console.WriteLine();
        }

        public StaticPerson()
        {
            Console.WriteLine($"Calling instance constructor, creating new object ...");

            Console.WriteLine($"Reducing {nameof(StaticAge)} in the instance constructor.");
            StaticAge += 1;

            ReadOnlyAccountBalance += 1;
        }

        internal void ChangeData(string name, int age)
        {
            Console.WriteLine($"{name} is changing the state of {nameof(StaticPerson)}.");
            Name = name;
            StaticAge += age;
        }

        public override string ToString() => $"Name: {Name}, Age: {StaticAge}, Account balance: {ReadOnlyAccountBalance}, Loan amount: {StaticReadOnlyLoanAmount}";
    }
}
