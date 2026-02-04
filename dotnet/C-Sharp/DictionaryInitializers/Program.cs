using static System.Console;

namespace DictionaryInitializers;

class Program
{
    static void Main(string[] args)
    {
        var dictFromCs3 = new Dictionary<string, string>
        {
            { "duck", "quack" },
            { "cow", "moo" }
        };

        WriteLine($"Cows say '{dictFromCs3["cow"]}'");

        var dictFromCs6 = new Dictionary<string, string>
        {
            ["English"] = "Hello!",
            ["French"] = "Bonjour!"
        };

        WriteLine($"In France, say '{dictFromCs6["French"]}'");
    }
}
