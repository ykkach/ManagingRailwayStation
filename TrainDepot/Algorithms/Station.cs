using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Station
    {
        //
        // Stores information about train station
        public string stationName { get; private set; }
        public int timeOfArrival { get; private set; }
        public int timeOfDeparture { get; private set; }
        public int kilometersFromPrevious { get; set; }

        public Station(string name, int km, int arrival, int departure)
        {
            this.stationName = name;
            this.kilometersFromPrevious = km;
            this.timeOfDeparture = departure;
            this.timeOfArrival = arrival;
        }
    }
}
