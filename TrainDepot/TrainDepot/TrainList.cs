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
    class TrainList
    {
        private static readonly TrainList instance = new TrainList();
        public List<Train> trainList { get; private set; } //change accessibility modifier to private?

        public TrainList()
        {
            trainList = new List<Train>();
        }
        private void addTrain(Train train) => trainList.Add(train);

        public static TrainList getList()
        {
            return instance;
        }

        public static void addToDataGrid(ref DataGridView trainTable, TrainList list)
        {
            //add list to form
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
                if (((Train)train).stations.Where(st => String.Compare(st.stationName, station) == 0).Count() > 0)
                    numberOfSpecificTrains++;
            return numberOfSpecificTrains;
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
                for (int i = 0; i < parsedData.GetLength(0); i++)
                {
                    if (String.IsNullOrEmpty(parsedData[i][0]))
                        return -1;
                    ltrainNumber = Convert.ToInt32(parsedData[i][0]);
                    for (int k = 1; k < parsedData.GetLength(1); k += 6)
                    {
                        if (String.IsNullOrEmpty(parsedData[i][k]))
                        {
                            return -1;
                        }
                        else
                        {
                            lstations.Add(parsedData[i][k]);
                            lkilometers.Add(Convert.ToInt32(parsedData[i][k + 1]));
                            larrivals.Add(Convert.ToInt32(parsedData[i][k + 2]) + Convert.ToInt32(parsedData[i][k + 3]));
                            ldepartures.Add(Convert.ToInt32(parsedData[i][k + 4]) + Convert.ToInt32(parsedData[i][k + 5]));

                            Train train = new Train(ltrainNumber, lstations, lkilometers, larrivals, ldepartures);
                            TrainList.getList().addTrain(train);
                        }
                    }
                }
            }
            return 0;
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
