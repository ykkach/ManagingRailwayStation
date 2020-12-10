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
        public List<Station> getSetStations
        {
            set { stations = value; }
            get { return stations; }
        }
        private int trainNumber;
        public int getSetTrainNumber
        {
            private set { trainNumber = value; }
            get { return trainNumber; }
        }
        private double avgSpeed;
        public double getSetAvgSpeed
        {
            private set { avgSpeed = value; }
            get { return avgSpeed; }
        }
        
        public void getAverageSpeed()
        {
            avgSpeed = 0;
            double[] speedOnEach = new double[stations.Count];    
            for (int i = 1; i < stations.Count; i++)
            {
                speedOnEach[i - 1] += stations[i].kilometersFromPrevious;
                if (stations[i].timeOfArrival < stations[i - 1].timeOfDeparture){
                    speedOnEach[i - 1] /= (stations[i].timeOfArrival + (GlobalVariables.NumOfMinutesInDay - stations[i - 1].timeOfDeparture))/GlobalVariables.NumOfMinutesInHour;
                }
                else{
                    speedOnEach[i - 1] /= (stations[i].timeOfArrival - stations[i - 1].timeOfDeparture)/GlobalVariables.NumOfMinutesInHour;
                }
                foreach (double sp in speedOnEach)
                    avgSpeed += sp;
                avgSpeed /= speedOnEach.Length;
            }
        }

        private void addStations(List<string> stationNames, List<int> kilometers, List<int> timesOfArrival, List<int> timesOfDeparture)
        {
            for (int i = 0; i < stationNames.Count; ++i)
            {
                Station sStation =
                    new Station(stationNames[i], Array.IndexOf(stationNames.ToArray(), stationNames[i]), kilometers[i], timesOfArrival[i], timesOfDeparture[i]);
                stations.Add(sStation);
            }
        }

        public override bool Equals(object o)
        {
            if (((Train)o).getSetStations[getSetStations.Count - 1].stationName == this.getSetStations[getSetStations.Count - 1].stationName &&
                ((Train)o).getSetStations[1].stationName == this.getSetStations[1].stationName &&
                ((Train)o).getSetStations[2].stationName == this.getSetStations[2].stationName &&
                ((Train)o).getSetStations[3].stationName == this.getSetStations[3].stationName)
                return true;
            else
                return false;
        }

        public int CompareTo(Train other)
        {
            return this.avgSpeed.CompareTo(other.avgSpeed);
        }

        public static bool operator >=(Train T1, Train T2) => 
            String.Compare(T1.stations.First().stationName, T2.stations.First().stationName) < 0 ? true : false;
        public static bool operator <=(Train T1, Train T2) =>
            String.Compare(T1.stations.First().stationName, T2.stations.First().stationName) > 0 ? true : false;
    }

    public static class GlobalVariables
    {
        public static int NumOfMinutesInDay = 1440;
        public static int NumOfMinutesInHour = 60;
        public static int numOfHoursInDay = 24;
        public static string fileNameToSave = @"C:\\Users\\Yaroslav\\Desktop\\other\\student\\2nd_course\\OOP";
        public static int systemTableInit = 0;
    }

}
