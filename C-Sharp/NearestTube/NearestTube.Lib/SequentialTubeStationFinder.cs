using System.Collections.Generic;
using System.Linq;

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
