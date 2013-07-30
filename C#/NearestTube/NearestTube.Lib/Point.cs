using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NearestTube.Lib
{
    public class Point
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public Point(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override bool Equals(object that)
        {
            if (that == null || this.GetType() != that.GetType())
            {
                return false;
            }

            var thatPoint = (Point)that;

            return Latitude == thatPoint.Latitude
                && Longitude == thatPoint.Longitude;
        }

        public override int GetHashCode()
        {
            return Latitude.GetHashCode() ^ Longitude.GetHashCode();
        }
    }
}