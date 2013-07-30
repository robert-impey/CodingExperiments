using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NearestTube.Lib
{
    public class TubeStation
    {
        public string Name { get; private set; }
        public Point Point { get; private set; }

        public TubeStation(string name, Point point)
        {
            Name = name;
            Point = point;
        }

        public override bool Equals(object that)
        {
            if (that == null || this.GetType() != that.GetType())
            {
                return false;
            }

            var thatTubeStation = (TubeStation)that;

            return Name.Equals(thatTubeStation.Name)
                && Point.Equals(thatTubeStation.Point);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Point.GetHashCode();
        }
    }
}
