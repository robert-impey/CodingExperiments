internal class Program
{
    private static async Task Main(string[] args)
    {
        await Task.Run(Hello);
        Goodbye();
    }

    static void Hello()
    {
        Console.WriteLine("Hello");    
    }

    static void Goodbye()
    {
        Console.WriteLine("Goodbye");
    }
}