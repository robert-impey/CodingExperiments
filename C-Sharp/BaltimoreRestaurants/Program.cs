using System.Linq;
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

                foreach (var restaurant in RestaurantReader.ReadXml(restaurantsXml).OrderBy(r => r.Name))
                {
                    WriteLine($"Name - {restaurant.Name}");
                }
            }
        }
    }
}
