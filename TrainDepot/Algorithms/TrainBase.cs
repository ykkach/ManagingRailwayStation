using System.Collections.Generic;
using System;

namespace BL
{
    public partial class Train : IComparable<Train>
    {
        //
        // Stores information about each train
        public Train() : this(0)
        { }
        public Train(int number)
        {
            trainNumber = number;
        }
        public Train(int number, List<string> stationNames, List<int> kilometers, List<int> timesOfArrival, List<int> timesOfDeparture)
        {
            trainNumber = number;
            stations = new List<Station>(stationNames.Count);
            addStations(stationNames, kilometers, timesOfArrival, timesOfDeparture);
            getAverageSpeed();
        }
        // Copying constructor
        public Train(Object train)
        {
            this.trainNumber = ((Train)train).trainNumber;
            this.stations = new List<Station>(((Train)train).stations.Count);
            for(int i = 0; i < ((Train)train).stations.Count; i++)
            {
                Station station = new Station(((Train)train).stations[i].stationName, 
                    ((Train)train).stations[i].kilometersFromPrevious,
                    ((Train)train).stations[i].timeOfArrival,
                ((Train)train).stations[i].timeOfDeparture);
                this.stations.Add(station);
            }
        }

    }
}