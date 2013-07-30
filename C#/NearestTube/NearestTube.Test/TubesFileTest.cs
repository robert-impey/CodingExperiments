using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using NearestTube.Lib;

namespace NearestTube.Test
{
    [TestFixture]
    class TubesFileTest
    {
        [Test]
        public void ReadTubesFile()
        {
            var expectedTubeStations = new LinkedList<TubeStation>();
            expectedTubeStations.AddLast(new TubeStation("Acton Town",
                new Point(51.503071, -0.280303)));
            expectedTubeStations.AddLast(new TubeStation("Aldgate",
                new Point(51.514342, -0.075627)));
            expectedTubeStations.AddLast(new TubeStation("Aldgate East",
                new Point(51.51503, -0.073162)));
            expectedTubeStations.AddLast(new TubeStation("All Saints (DLR)",
                new Point(51.510477, -0.012625)));
            expectedTubeStations.AddLast(new TubeStation("Alperton",
                new Point(51.541209, -0.299516)));
            expectedTubeStations.AddLast(new TubeStation("Amersham",
                new Point(51.674129, -0.606514)));

            var csv = new StringBuilder()
                    .Append("\"Acton Town\",51.503071,-0.280303\n")
                    .Append("\"Aldgate\",51.514342,-0.075627\n")
                    .Append("\"Aldgate East\",51.51503,-0.073162\n")
                    .Append("\"All Saints (DLR)\",51.510477,-0.012625\n")
                    .Append("\"Alperton\",51.541209,-0.299516\n")
                    .Append("\"Amersham\",51.674129,-0.606514")
                    .ToString();

            var tubeStationsFile = new TubeStationsFile(new StringReader(csv));

            ICollection<TubeStation> actualTubeStations;
            actualTubeStations = tubeStationsFile.TubeStations;

            Assert.That(expectedTubeStations, Is.EqualTo(actualTubeStations));
        }
    }
}
