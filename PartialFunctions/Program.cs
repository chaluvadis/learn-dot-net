namespace PartialFunctions;
public static class Program
{
    public static void Main()
    {
        int res = Implementation.Do(5, "Hello", 4);
        Console.WriteLine($"Result = {res}");
        Func<int, int> func = Implementation.ApplyDo(5, "Hello");
        int funcResult = func(4);
        Console.WriteLine($"FuncResult = {funcResult}");
        Console.ReadLine();
    }
}
