internal class Program
{
    static async Task Main(string name = "World")
    {
        Console.Write("Hello, ..");
        await Task.Delay(1000);
        Console.WriteLine($"{name}!");
    }
}