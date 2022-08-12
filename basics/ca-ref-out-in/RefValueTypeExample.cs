class RefValueTypeExample
{
    static void IncrementExample(ref int num)
    {
        num = num + 1;
    }

    static void Invoke()
    {
        int num = 1;
        IncrementExample(ref num);
        // num is now 2
    }
}
