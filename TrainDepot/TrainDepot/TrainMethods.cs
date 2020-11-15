using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace TrainDepot
{
    partial class CTrain
    {
        public static int trainNumber { get; private set; }
        public struct SStation
        {
            public string stationName { get; set; }
            public int stationID { get; set; }
            /*
            private static implicit operator SStation(string value)
            {
                return new SStation() { stationName = value, stationID = index of name in the array };
            }*/
        };

        public static List<SStation> stations;
        //public int currentStationID { get; private set; }

        private void addStations(string[] stationNames, int stationsQuantity) 
        {
            //is there a point in repeatedly adding stations one by one?
            for (int i = 0; i < stationsQuantity; ++i)
            {
                SStation sStation = new SStation { stationName = stationNames[i], stationID = Array.IndexOf(stationNames, stationNames[i]) };
                stations.Add(sStation);
            }
        }


        // Implement access to initial/final station
        // or give access directly to field "stations" 


    }
}
