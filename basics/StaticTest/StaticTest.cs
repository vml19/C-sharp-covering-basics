namespace code_challenges
{
    internal class StaticTest
    {
        public static int StaticAge = 0;
        public string Name = "";
        public static readonly int StaticReadOnlyBalance = 1;

        static StaticTest()
        {
            StaticReadOnlyBalance = 1111;
        }

        public StaticTest()
        {
            StaticAge = 1000;
        }
        internal string GetData()
        {
            StaticAge = 10;
            Name = "New Name";
            Console.WriteLine(Name + StaticAge);
            return Name + StaticAge;
        }

        internal string ChangeData()
        {
            StaticAge = 100;
            Name = "New Name_100";
            Console.WriteLine(Name + StaticAge);
            return Name + StaticAge;
        }

        public override string ToString() => Name + StaticAge;
    }

    public static class StaticClass
    {
        private static int Age = 0;
        public static string Name = "";
        public static readonly int Balance = 1;
    }
}
