using System;
namespace PartialFunctions;
internal static class Implementation
{
    public static int Do(int configA, string configB, int data)
    {
        return configA + configB.Length + data;
    }
    public static Func<int, int> ApplyDo(int configA, string configB) => (data) => Do(configA, configB, data);
}
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
