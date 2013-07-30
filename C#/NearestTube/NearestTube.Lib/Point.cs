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

        /// <summary>
        /// Porting JavaScript code from
        /// http://www.johndcook.com/lat_long_distance.html
        /// </summary>
        /// <param name="that"></param>
        /// <returns></returns>
        public double Distance(Point that)
        {
            // Compute spherical coordinates

            double rho = 6373;

            // convert latitude and longitude to spherical coordinates in radians
            // phi = 90 - latitude
            double phi1 = (90.0 - this.Latitude) * Math.PI / 180.0;
            double phi2 = (90.0 - that.Latitude) * Math.PI / 180.0;
            // theta = longitude
            double theta1 = this.Longitude * Math.PI / 180.0;
            double theta2 = that.Longitude * Math.PI / 180.0;

            // compute spherical distance from spherical coordinates
            // arc length = \arccos(\sin\phi\sin\phi'\cos(\theta-\theta') + \cos\phi\cos\phi')
            // distance = rho times arc length
            return rho * Math.Acos(
                    Math.Sin(phi1) * Math.Sin(phi2) * Math.Cos(theta1 - theta2)
                    + Math.Cos(phi1) * Math.Cos(phi2)) * 1000;
        }
    }
}