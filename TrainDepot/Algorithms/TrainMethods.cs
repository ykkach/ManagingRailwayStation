using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    public partial class Train : IComparable<Train>
    {
        private List<Station> stations;
        public int trainNumber;
        private double avgSpeed;
        public int getSetTrainNumber
        {
            private set { trainNumber = value; }
            get { return trainNumber; }
        }
        public List<Station> getSetStations
        {
            private set { stations = value; }
            get { return stations; }
        }

        public void getAverageSpeed()
        {
            double[] speedOnEach = new double[stations.Count];    
            for (int i = 1; i < stations.Count; i++)
            {
                speedOnEach[i - 1] += stations[i].kilometersFromPrevious;
                if (stations[i].timeOfArrival < stations[i - 1].timeOfDeparture){
                    speedOnEach[i - 1] /= (stations[i].timeOfArrival + (GlobalVariables.NumOfSecondsInDay - stations[i - 1].timeOfDeparture))/GlobalVariables.NumOfSecondsInHour;
                }
                else{
                    speedOnEach[i - 1] /= (stations[i].timeOfArrival - stations[i - 1].timeOfDeparture)/GlobalVariables.NumOfSecondsInHour;
                }
                foreach (double sp in speedOnEach)
                    avgSpeed += sp;
                this.avgSpeed /= speedOnEach.Length;
            }
        }

        private void addStations(List<string> stationNames, List<int> kilometers, List<int> timesOfArrival, List<int> timesOfDeparture)
        {
            // check for empty array

            for (int i = 0; i < stationNames.Count; ++i)
            {
                Station sStation =
                    new Station(stationNames[i], Array.IndexOf(stationNames.ToArray(), stationNames[i]), kilometers[i], timesOfArrival[i], timesOfDeparture[i]);
                stations.Add(sStation);
            }
        }

        /*
         How to generate a list of
        private void generateStations (int* stationsPlaces, int size, someRandomGenerator &generator)
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
            return this.avgSpeed.CompareTo(other.avgSpeed);
        }

        public static bool operator >=(Train T1, Train T2) => String.Compare(T1.stations.First().stationName, T2.stations.First().stationName) < 0 ? true : false;
        public static bool operator <=(Train T1, Train T2) => String.Compare(T1.stations.First().stationName, T2.stations.First().stationName) > 0 ? true : false;

        // Implement access to initial/final station
        // or give access directly to field "stations" 

    }

    public static class GlobalVariables
    {
        public static int NumOfSecondsInDay = 86400;
        public static int NumOfSecondsInHour = 3600;
        public static string fileNameToOpen;
        public static string fileNameToSave;
    }

}
