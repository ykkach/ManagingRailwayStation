using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BL
{
    public partial class Train : IComparable<Train>
    {
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
        public Train(Train train)
        {
            //copy fields
        }

    }
}