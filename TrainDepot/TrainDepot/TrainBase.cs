using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainDepot
{
    public partial class Train
    {
        public Train() : this (0)
        {}
        public Train(int number)
        {
            trainNumber = number;
        }
        public Train(int number, string[] stationNames, int stationQuantity)
        {
            trainNumber = number;
            stations = new List<SStation>(stationQuantity);
            addStations(stationNames, stationQuantity);
        }
        public Train(Train train)
        {

        }

    }
}
