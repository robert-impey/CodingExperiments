using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NearestTube.Lib;

namespace NearestTube
{
    class Program
    {
        private const string csvFileName = @"Resources/tube.csv";

        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                double latitude, longitude;

                if (Double.TryParse(args[0], out latitude) && Double.TryParse(args[1], out longitude))
                {
                    var currentLocation = new Point(latitude, longitude);
                    try
                    {
                        using (var csvReader = new StreamReader(csvFileName))
                        {
                            var tubeStationsFile = new TubeStationsFile(csvReader);
                            var tubeStations = tubeStationsFile.TubeStations;

                            var finder = new SequentialTubeStationFinder(tubeStations);

                            var nearestTubeStation = finder.FindNearestTubeStation(currentLocation);

                            Console.WriteLine(String.Format("The nearest station is {0}.", nearestTubeStation.Name));
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The CSV file could not be read:");
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("The latitude and longitude need to be floating point numbers!");
                }
            }
            else
            {
                Console.WriteLine("Give me the latitude and longitude of where you are!");
            }
        }
    }
}
