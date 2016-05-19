using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltimoreRestaurants.Tests
{
    [TestClass]
    public class ReadRestaurants
    {
        [TestMethod]
        public void ReadXml()
        {
            // Arrange
            var restaurantsXml = @"<response>
	<row>
		<row>
            <name>Chez Robert</name> 
    	</row>
    </row>
</response>";

            // Act
            var restaurants = RestaurantReader.ReadXml(XElement.Parse(restaurantsXml));
            var firstRestaurant = restaurants.FirstOrDefault();

            // Assert
            Assert.IsNotNull(firstRestaurant);
            Assert.AreEqual("Chez Robert", firstRestaurant.Name);
        }
    }
}
