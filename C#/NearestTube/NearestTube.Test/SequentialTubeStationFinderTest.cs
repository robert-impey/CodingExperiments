using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NearestTube.Lib;

namespace NearestTube.Test
{
    [TestFixture]
    class SequentialTubeStationFinderTest
    {
        [Test]
        public void FindNearestStation()
        {
            var point = new Point(51.499, -0.275);

            var tubeStations = new LinkedList<TubeStation>();
            tubeStations.AddLast(new TubeStation("Acton Town",
                new Point(51.503071, -0.280303)));
            tubeStations.AddLast(new TubeStation("Chiswick Park",
                new Point(51.494371,-0.267737)));

            var finder = new SequentialTubeStationFinder(tubeStations);

            var expectedNearestTubeStationName = "Acton Town";
            var foundNearestTubeStation = finder.FindNearestTubeStation(point);

            Assert.AreEqual(expectedNearestTubeStationName, foundNearestTubeStation.Name);
        }
    }
}
