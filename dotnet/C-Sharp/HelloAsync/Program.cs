internal class Program
{
    private static async Task Main(string[] args)
    {
        await Hello();
        Goodbye();
    }

    async static Task Hello()
    {
        await Task.Delay(TimeSpan.FromMilliseconds(50));
        Console.WriteLine("Hello");
    }

    static void Goodbye()
    {
        Console.WriteLine("Goodbye");
    }
}