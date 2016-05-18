using System.Xml.Linq;
using static System.Console;

/// <summary>
/// Parsing and manipulating the data found in the
/// Baltimore Restaurants database
/// https://data.baltimorecity.gov/Culture-Arts/Restaurants/k5ry-ef3g
/// </summary>

namespace BaltimoreRestaurants
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                WriteLine("Please set the file location!");
            }
            else
            {
                var restaurantsFile = args[0];
                var restaurantsXml = XElement.Load(restaurantsFile);

                var restaurantRows = restaurantsXml?.Element("row")?.Elements();
                if (restaurantRows == null)
                {
                    WriteLine("Unable to parse restaurants!");
                }
                else
                {
                    foreach (var restaurantRow in restaurantRows)
                    {
                        var restaurantName = restaurantRow.Element("name");
                        if (restaurantName == null)
                        {
                            WriteLine("No name found");
                        }
                        else
                        {
                            WriteLine($"Name - {restaurantName.Value}");
                        }
                    }
                }
            }
        }
    }
}
