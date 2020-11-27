using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

NUM_OF_SECS_IN_
namespace BL
{
    public partial class Train : IComparable<Train>
    {
        public static int trainNumber { get; private set; }
        private static int timeOfArrival; // in seconds
        private static int timeOfDeparture; // in seconds
        private static List<Station> stations;
        private int avgSpeed;
        //public int currentStationID { get; private set; }
        public static void getAverageSpeed()
        {
            int avgSpeed;
            int time;
            for (int i = 0; i < stations.Count; i++)
            {
                if (timeOfArrival < timeOfDeparture)
                {
                    
                }

            }
            //Count speed with cStation fields
        }

        private void addStations(string[] stationNames, int[] kilometers, int[] times)
        {
            for (int i = 0; i < stationNames.Length; ++i)
            {
                Station sStation =
                    new Station(stationNames[i], Array.IndexOf(stationNames, stationNames[i]), kilometers[i]);
                stations.Add(sStation);
            }
            timeOfArrival = times[1];
            timeOfDeparture = times[0];
        }

        /*
        private void generateStations (int* stationsPlaces, int size, QRandomGenerator &generator)
        {
            for (int i = 0; i < size; ++i)
            {
                int j = generator.generate() % (i + 1);
                arr[i] = arr[j];
                arr[j] = i;
            }
        }
        */

        public int CompareTo(Train other)
        {
            //here can be custom return(for example if we compare speed -
            //-1 for this condition, if somthing else 1, etc
            
            return this.avgSpeed.CompareTo(other.avgSpeed);
        }

        public static bool operator >=(Train T1, Train T2) => T1.avgSpeed > T2.avgSpeed ? true : false;
        public static bool operator <=(Train T1, Train T2) => T1.avgSpeed < T2.avgSpeed ? true : false;

        // Implement access to initial/final station
        // or give access directly to field "stations" 

    }

}
