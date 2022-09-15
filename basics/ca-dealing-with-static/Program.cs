using code_challenges;

class Program
{
    static void Main(string[] args)
    {
        //This assignment happend only after the static constructor is being called.
        StaticPerson.StaticAge = 20;

        Console.WriteLine("-------------------------------------------");

        var obj1 = new StaticPerson();
        Console.WriteLine(obj1.ToString());

        //Console.WriteLine("-------------------------------------------");
        obj1.ChangeData("Obj1", 100);
        Console.WriteLine(obj1.ToString());

        Console.WriteLine("-------------------------------------------");

        var obj2 = new StaticPerson();
        Console.WriteLine(obj1.ToString());

        //Console.WriteLine("-------------------------------------------");
        obj2.ChangeData("Obj2", 200);
        Console.WriteLine(obj2.ToString());
    }
}