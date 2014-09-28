﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NearestTube.Lib
{
    interface ITubeStationFinder
    {
        TubeStation FindNearestTubeStation(ICollection<TubeStation> tubeStations, Point point);
    }
}
