namespace PartialFunctions;

internal static class Implementation
{
    public static int Do(int configA, string configB, int data)
        => configA + configB.Length + data;
    public static Func<int, int> ApplyDo(int configA, string configB)
        => (data) => Do(configA, configB, data);
}
