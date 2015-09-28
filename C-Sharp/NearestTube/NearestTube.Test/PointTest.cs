using NUnit.Framework;
using NearestTube.Lib;

namespace NearestTube.Test
{
    [TestFixture]
    class PointTest
    {
        private const double tolerance = 0.001;

        private Point actonTown, chiswickPark;

        [SetUp]
        public void SetUp()
        {
            actonTown = new Point(51.503071, -0.280303);
            chiswickPark = new Point(51.494371, -0.267737);
        }

        [TearDown]
        public void TearDown()
        {
            actonTown = chiswickPark = null;
        }

        [Test]
        public void Distance()
        {
            var expectedDistance = 1301.3668588181595;

            var calculatedDistance = actonTown.Distance(chiswickPark);

            Assert.AreEqual(expectedDistance, calculatedDistance, tolerance);
        }
    }
}
