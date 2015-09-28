using System.Collections.Generic;

namespace NearestTube.Lib
{
    interface ITubeStationFinder
    {
        TubeStation FindNearestTubeStation(ICollection<TubeStation> tubeStations, Point point);
    }
}
