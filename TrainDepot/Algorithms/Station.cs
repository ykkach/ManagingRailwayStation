using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class Station
    {
        public string stationName { get; set; }
        public int stationID { get; set; }

        public int kilometersFromPrevious { get; set; }

        public Station(string name, int ID, int km)
        {
            this.stationName = name;
            this.stationID = ID;
            this.kilometersFromPrevious = km;
        }
    }
}
