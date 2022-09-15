using extention_methods;

class Program
{
    static void Main(string[] args)
    {
        //string txt = "Calling an extention method";
        //Console.WriteLine(txt.ParseInt32());

        var sealedObj = new SealedClass();
        sealedObj.PrintName();
        sealedObj.ExtendedPrintName();
    }
}