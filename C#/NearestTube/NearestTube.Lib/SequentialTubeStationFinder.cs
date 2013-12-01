using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NearestTube.Lib
{
    public class SequentialTubeStationFinder : ITubeStationFinder
    {
        public TubeStation FindNearestTubeStation(ICollection<TubeStation> tubeStations, Point point)
        {
            return (from tubeStation in tubeStations
                    orderby tubeStation.Point.Distance(point)
                    select tubeStation).First();
        }
    }
}
