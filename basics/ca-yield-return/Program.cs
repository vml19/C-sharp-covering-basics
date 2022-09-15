partial class Program
{
    static bool didTheCodeRun = false;

    // Here's a variable to track execution of code in an iterator
    static int lastYielded = -1;
    static void Main(string[] args)
    {
        var numbers = GetOneTwoThree();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
            // Output:
            // 1
            // 2
            // 3
        }

        var doubledNumbers = numbers.Select(num => num * 2);
        foreach (var number in doubledNumbers)
        {
            Console.WriteLine(number);
            // Output:
            // 2
            // 4
            // 6
        }
        var numberArray = numbers.ToArray();
        Console.WriteLine(numberArray[0]); // Output: 1

        //Testing lazy evaluation
        bool didTheCodeRun = false;
        var results = RunTheCode();
        Console.WriteLine(didTheCodeRun); // Output: false, That’s right, after we run RunTheCode(), which explicitly sets didTheCodeRun to true,
                                          // the value of didTheCodeRun is still false.
                                          // None of the code in our iterator runs until we start iterating through the IEnumerable.
                                          // It’s lazily evaluated!
        
        //Test MORE
        numbers = GetOneToTen();
        Console.WriteLine(lastYielded); // Output: -1

        // This gives us an 'instance' of the iteration
        var enumerator = numbers.GetEnumerator();

        // This executes the iterator until the first yield return is reached
        enumerator.MoveNext();

        // This gives us the current (most recently yielded) value of the iterator
        Console.WriteLine(enumerator.Current); // Output: 1
        Console.WriteLine(lastYielded); // Output: 1

        // This will iterate from 1 to 4, then stop
        foreach (var num in numbers)
        {
            if (num >= 4)
            {
                break;
            }
        }

        Console.WriteLine(lastYielded); // Output: 4

        // This will not execute any code in the iterator.
        //  LINQ methods are lazily evaluated as well
        var numbersTimesTwo = numbers.Select(num => num * 2);
        Console.WriteLine(lastYielded); // Output: 4

        // This will force the entire iterator to run, yielding all values
        var arr = numbers.ToArray();
        Console.WriteLine(lastYielded); // Output: 10
    }

    static IEnumerable<int> GetOneTwoThree()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        // We could put "yield break;" here but there's no need, the end of the function signals the same thing.
    }

    static IEnumerable<bool> RunTheCode()
    {
        didTheCodeRun = true;
        yield return true;
    }

    // Here's an iterator for us to play with
    static IEnumerable<int> GetOneToTen()
    {
        for (var num = 1; num <= 10; num++)
        {
            lastYielded = num;
            yield return num;
        }
    }
}


//https://stackoverflow.blog/2022/06/15/c-ienumerable-yield-return-and-lazy-evaluation/