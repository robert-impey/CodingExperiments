using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NearestTube.Lib
{
    public class SequentialTubeStationFinder : ITubeStationFinder
    {
        private readonly ICollection<TubeStation> tubeStations;

        public SequentialTubeStationFinder(ICollection<TubeStation> someTubeStations)
        {
            tubeStations = someTubeStations;
        }

        public TubeStation FindNearestTubeStation(Point point)
        {
            return (from tubeStation in tubeStations
                    orderby tubeStation.Point.Distance(point)
                    select tubeStation).First();
        }
    }
}
