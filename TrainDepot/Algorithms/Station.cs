using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Station
    {
        public string stationName { get; private set; }
        public int timeOfArrival { get; private set; }
        public int timeOfDeparture { get; private set; }
        public int stationID { get; private set; }

        public int kilometersFromPrevious { get; set; }

        public Station(string name, int ID, int km, int arrival, int departure)
        {
            this.stationName = name;
            this.stationID = ID;
            this.kilometersFromPrevious = km;
            this.timeOfDeparture = departure;
            this.timeOfArrival = arrival;
        }
    }
}
