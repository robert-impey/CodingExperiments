using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltimoreRestaurantsTests
{
    [TestClass]
    public class RestaurantFileReading
    {
        #region Happy Path

        [TestMethod]
        public void ReadRestaurants()
        {
            // Arrange
            var xml = @"<response>
    	<row>
    		<row>
                <name>Chez Robert</name> 
        </row>
    </row>
</response>
";
        }

        #endregion
    }
}
