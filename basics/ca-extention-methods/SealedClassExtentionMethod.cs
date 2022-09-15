namespace extention_methods
{
    internal sealed class SealedClass
    {
        public void PrintName()
        {
            Console.WriteLine("I am from a sealed class.");
        }
    }

    internal static class SealedClassExtentionMethod
    {
        public static void ExtendedPrintName(this SealedClass sealedClass)
        {
            Console.WriteLine("I am from a Sealed Class Extention Method.");
        }
    }
}
