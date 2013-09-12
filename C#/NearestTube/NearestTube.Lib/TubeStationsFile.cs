using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NearestTube.Lib
{
    public class TubeStationsFile
    {
        private TextReader reader;

        public TubeStationsFile(TextReader aReader)
        {
            reader = aReader;
        }

        public ICollection<TubeStation> TubeStations
        {
            get
            {
                var tubeStations = new LinkedList<TubeStation>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(new char[] { ',' });

                    var name = values[0];
                    var quotes = new char[] { '"' };
                    name = name.TrimStart(quotes).TrimEnd(quotes);

                    double latitude, longitude;
                    if (Double.TryParse(values[1], out latitude)
                        && Double.TryParse(values[2], out longitude))
                    {
                        tubeStations.AddLast(new TubeStation(name,
                            new Point(latitude, longitude)));
                    }
                }

                return tubeStations;
            }
        }
    }
}
