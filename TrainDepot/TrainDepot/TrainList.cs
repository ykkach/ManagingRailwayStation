using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BL;

namespace TrainDepot
{
    class TrainList
    {
        private static readonly TrainList instance = new TrainList();
        public List<Train> trainList { get; private set; }

        public TrainList()
        {
            trainList = new List<Train>();
        }
        public void addTrain(Train train) => trainList.Add(train);

        public static TrainList getList()
        {
            return instance;
        }

        public static void inputList(ref DataGridView trainTable, TrainList list)
        {
            //add list to form
        }
        public void sortBySpeed()
        {
            MergeSort mergeSort = new MergeSort();
            mergeSort.mergeSort(trainList);  // mersort list by avgSpeed ...   
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
