using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BaltimoreRestaurants
{
    public static class RestaurantReader
    {
        public static IEnumerable<Restaurant> ReadXml(XElement restaurantsXml)
        {
            var restaurants = new List<Restaurant>();

            var restaurantRows = restaurantsXml?.Element("row")?.Elements();
            if (restaurantRows == null)
            {
                throw new Exception("Unable to parse restaurants!");
            }
            else
            {
                foreach (var restaurantRow in restaurantRows)
                {
                    var restaurantName = restaurantRow.Element("name");
                    if (restaurantName == null)
                    {
                        throw new Exception("Row with no name found");
                    }
                    else
                    {
                        restaurants.Add(new Restaurant(restaurantName.Value));
                    }
                }
            }

            return restaurants;
        }
    }
}
