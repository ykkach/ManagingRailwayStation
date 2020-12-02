using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Runtime;
using System.Text.RegularExpressions;
using BL;


namespace TrainDepot
{
    public class TrainList
    {
        private static readonly TrainList instance = new TrainList();
        public List<Train> trainList
        { 
            get;
            private set; 
        }

        private TrainList()
        {
            trainList = new List<Train>();
        }

        public static TrainList getList()
        {
            return instance;
        }

        private void addTrain(Train train) => trainList.Add(train);

        public void clearList()
        {
            trainList.Clear();
        }

        public void sortBySpeed()
        {
            MergeSort mergeSort = new MergeSort();
            mergeSort.sortBySpeed(trainList);  
            // mersort list by avgSpeed 
        }

        public void sortByFStation()
        {
            MergeSort mergeSort = new MergeSort();
            mergeSort.sortByFStation(trainList); 
            //mergesort list by initial station
        }

        public int getNumberOfRoutesWithStation(String station)
        {
            int numberOfSpecificTrains = 0;
            foreach (Train train in trainList)
                if (((Train)train).getSetStations.Where(st => 
                String.Compare(st.stationName, station) == 0).Count() > 0)
                    numberOfSpecificTrains++;
            return numberOfSpecificTrains;
        }

        public int parseDataSingleRecord(string data)
        {
            if (String.IsNullOrEmpty(data))
            {
                return -1;
            }
            else 
            {
                int ltrainNumber = 0;
                List<string> lstations = new List<string>();
                List<int> lkilometers = new List<int>();
                List<int> larrivals = new List<int>();
                List<int> ldepartures = new List<int>();

                var parsedData = data.Split(' ');
                
                foreach (string tr in parsedData)
                    if (String.IsNullOrEmpty(tr))
                    {
                        return -1;
                    }

                ltrainNumber = Convert.ToInt32(parsedData[0]);
                for (int k = 0; k < parsedData.Length - 1;)
                {
                    lstations.Add(parsedData[++k]);
                    lkilometers.Add(Convert.ToInt32(parsedData[++k]));
                    larrivals.Add(Convert.ToInt32(parsedData[++k]) * GlobalVariables.NumOfMinutesInHour + Convert.ToInt32(parsedData[++k]));
                    ldepartures.Add(Convert.ToInt32(parsedData[++k]) * GlobalVariables.NumOfMinutesInHour + Convert.ToInt32(parsedData[++k]));
                }
                Train train = new Train(ltrainNumber, lstations, lkilometers, larrivals, ldepartures);
                this.addTrain(train);
                lstations.Clear();
                lkilometers.Clear();
                larrivals.Clear();
                ldepartures.Clear();
            }

            return 0;
        }

        public int parseDataFromFile(string data)
        {
            int ltrainNumber = 0;
            List<string> lstations = new List<string>();
            List<int> lkilometers = new List<int>();
            List<int> larrivals = new List<int>();
            List<int> ldepartures = new List<int>();

            if (String.IsNullOrEmpty(data))
            {
                return -1;
            }
            else
            {
                
                var parsedData = data.Split(',')
                   .Select(s => Regex.Split(s, "[^\\w]+"))
                   .ToArray();

                for (int i = 0; i < parsedData.Length; i++)
                {
                    if (String.IsNullOrEmpty(parsedData[i][0]))
                        return -1;
                    ltrainNumber = Convert.ToInt32(parsedData[i][0]);

                    for (int k = 0; k < parsedData[0].Length - 1;) 
                    {
                        if (String.IsNullOrEmpty(parsedData[i][k]))
                        {
                            return -1;
                        }
                        else
                        {
                            lstations.Add(parsedData[i][++k]);
                            lkilometers.Add(Convert.ToInt32(parsedData[i][++k]));
                            larrivals.Add(Convert.ToInt32(parsedData[i][++k])* GlobalVariables.NumOfMinutesInHour + Convert.ToInt32(parsedData[i][++k]));
                            ldepartures.Add(Convert.ToInt32(parsedData[i][++k])* GlobalVariables.NumOfMinutesInHour + Convert.ToInt32(parsedData[i][++k]));
                        }
                    }
                    Train train = new Train(ltrainNumber, lstations, lkilometers, larrivals, ldepartures);
                    this.addTrain(train);
                    lstations.Clear();
                    lkilometers.Clear();
                    larrivals.Clear();
                    ldepartures.Clear();
                }
            }
            return 0;
        }
        public void addToDataGrid(ref DataGridView trainTable)
        {
            while (trainTable.Rows.Count > 0)
                trainTable.Rows.Remove(trainTable.Rows[0]);
            //trainTable.Rows.Clear();

            foreach (Train train in trainList)
            {
                trainTable.Rows.Add(
                    new object[]
                    {
                        Convert.ToString(train.getSetTrainNumber),
                       train.getSetStations[0].stationName +  ' ' +
                       Convert.ToString(train.getSetStations[0].kilometersFromPrevious) + ' ' +
                       Convert.ToString(train.getSetStations[0].timeOfArrival/60) + ':' + Convert.ToString(train.getSetStations[0].timeOfArrival%60) + '/' +
                       Convert.ToString(train.getSetStations[0].timeOfDeparture/60) + ':' + Convert.ToString(train.getSetStations[0].timeOfDeparture%60),

                       train.getSetStations[1].stationName +  ' ' +
                       Convert.ToString(train.getSetStations[1].kilometersFromPrevious) + ' ' +
                       Convert.ToString(train.getSetStations[1].timeOfArrival/60) + ':' + Convert.ToString(train.getSetStations[1].timeOfArrival%60) + '/' +
                       Convert.ToString(train.getSetStations[1].timeOfDeparture/60) + ':' + Convert.ToString(train.getSetStations[1].timeOfDeparture%60),

                       train.getSetStations[2].stationName +  ' ' +
                       Convert.ToString(train.getSetStations[2].kilometersFromPrevious) + ' ' +
                       Convert.ToString(train.getSetStations[2].timeOfArrival/60) + ':' + Convert.ToString(train.getSetStations[2].timeOfArrival%60) + '/' +
                       Convert.ToString(train.getSetStations[2].timeOfDeparture/60) + ':' + Convert.ToString(train.getSetStations[2].timeOfDeparture%60),

                       train.getSetStations[3].stationName +  ' ' +
                       Convert.ToString(train.getSetStations[3].kilometersFromPrevious) + ' ' +
                       Convert.ToString(train.getSetStations[3].timeOfArrival/60) + ':' + Convert.ToString(train.getSetStations[3].timeOfArrival%60) + '/' +
                       Convert.ToString(train.getSetStations[3].timeOfDeparture/60) + ':' + Convert.ToString(train.getSetStations[3].timeOfDeparture%60),
                       
                       train.getSetStations[4].stationName +  ' ' +
                       Convert.ToString(train.getSetStations[4].kilometersFromPrevious) + ' ' +
                       Convert.ToString(train.getSetStations[4].timeOfArrival/60) + ':' + Convert.ToString(train.getSetStations[4].timeOfArrival%60) + '/' +
                       Convert.ToString(train.getSetStations[4].timeOfDeparture/60) + ':' + Convert.ToString(train.getSetStations[4].timeOfDeparture%60)
                    });
            }
        }

        static async void writeToFile(string sLog)
        {
            //string pathToFile = @"C:\\....";
            //DirectoryInfo dirInfo = new DirectoryInfo(pathToFile);
            //if (!dirInfo.Exists)
            //{
            //    dirInfo.Create();
            //}
            //string filename = $"{pathToFile}\\output.txt";

            //using (FileStream fstream = new FileStream(filename, FileMode.OpenOrCreate))
            //{
            //    byte[] array = System.Text.Encoding.Default.GetBytes(sLog);
            //    await fstream.WriteAsync(array, 0, array.Length);
            //}
        }

        
    }
}
