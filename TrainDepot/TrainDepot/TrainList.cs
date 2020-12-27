using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using BL;


namespace TrainDepot
{

    public class TrainList
    {

        // Stores list of trains and methods to 
        // modify this list according to user 
        // actions.

        private static readonly TrainList instance = new TrainList();
        public List<Train> trainList;

        private TrainList()
        {
            trainList = new List<Train>();
        }

        // Get static instance of TrainDepot
        public static TrainList getList()
        {
            return instance;
        }

        // Add new record to list
        private void addTrain(Train train) => trainList.Add(train);

        // Clear trainList
        public void clearList()
        {
            trainList.Clear();
        }

        // Sort trainList by average speed of train
        public void sortBySpeed()
        {
            MergeSort mergeSort = new MergeSort();
            trainList = mergeSort.sortBySpeed(trainList);  
        }

        // Sort trainList by name of initial station
        public void sortByFirstStation()
        {
            MergeSort mergeSort = new MergeSort();
            trainList = mergeSort.sortByFStation(trainList); 
        }

        // Group records that have similar intermediate
        // and final station
        public void groupByStationNames()
        {
            MergeSort mergeSort = new MergeSort();
            trainList = mergeSort.groupByLStation(trainList);
        }

        // Get list of train numbers
        // These trains must satisfy a condition below
        public List<int> getTrainsByStationArrival(string station, int timeOfArrival)
        {
            List<int> trainNumbers = new List<int>();
            foreach (Train train in trainList)
                foreach (Station st in train.getSetStations)
                    if (st.stationName == station && st.timeOfArrival == timeOfArrival)
                        trainNumbers.Add(train.getSetTrainNumber);
            return trainNumbers;
        }

        // Get list of train numbers
        // These trains must satisfy a condition below
        public List<int> getTrainsByStationDeparture(string station, int timeOfDeparture)
        {
            List<int> trainNumbers = new List<int>();
            foreach (Train train in trainList)
                foreach(Station st in train.getSetStations)
                    if(st.stationName == station && st.timeOfDeparture == timeOfDeparture)
                        trainNumbers.Add(train.getSetTrainNumber);
            return trainNumbers;
        }

        // Get list of train numbers
        // These trains must satisfy a condition below
        public List<int> getTrainsByStation(String station)
        {
            List<int> trainNumbers = new List<int>();
            foreach (Train train in trainList)
                if (((Train)train).getSetStations.Where(st => 
                String.Compare(st.stationName, station) == 0).Count() > 0)
                    trainNumbers.Add(train.getSetTrainNumber);
            return trainNumbers;
        }

        // Add new record to trainList with data passed
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
                
                if(checkForInvalidInput(parsedData) != 0)
                    return -1;
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
            for (int i = 0; i < trainList.Count; i++)
                for (int k = 0; k < trainList[0].getSetStations.Count; k++)
                    if (k != trainList[0].getSetStations.Count - 1)
                        if (checkTimeCorrectness(trainList[i].getSetStations[k + 1].kilometersFromPrevious,
                             trainList[i].getSetStations[k].timeOfDeparture / GlobalVariables.NumOfMinutesInHour,
                             trainList[i].getSetStations[k].timeOfDeparture % GlobalVariables.NumOfMinutesInHour,
                             trainList[i].getSetStations[k + 1].timeOfArrival / GlobalVariables.NumOfMinutesInHour,
                             trainList[i].getSetStations[k + 1].timeOfArrival % GlobalVariables.NumOfMinutesInHour) != 0)
                        {
                            trainList.RemoveAt(trainList.Count - 1);
                            return -1;
                        }
            return 0;
        }

        // Check if correct time was passed
        private int checkTimeCorrectness(int distance, int arrivalHours, int arrivalMinutes, int departureHours, int departureMinutes)
        {
            if (departureHours * GlobalVariables.NumOfMinutesInHour + departureMinutes == arrivalHours * GlobalVariables.NumOfMinutesInHour + arrivalMinutes)
                return -1;
           // else if (departureHours * GlobalVariables.NumOfMinutesInHour + departureMinutes - (arrivalHours * GlobalVariables.NumOfMinutesInHour + arrivalMinutes) < 15 && distance >= 5)
                //return -1;
            //else if (distance / (departureHours * GlobalVariables.NumOfMinutesInHour + departureMinutes - (arrivalHours * GlobalVariables.NumOfMinutesInHour + arrivalMinutes)) > 160)
              //  return -1;
            return 0;
        }

        // Check if there was invalid data passed
        private int checkForInvalidInput(string[] data)
        {
            foreach (string el in data)
                if (String.IsNullOrEmpty(el))
                    return -1;
            try
            {
                var value = int.Parse(data[0]);
                if (value < 0)
                    throw new NegativeValuePassedException();
            }
            catch (Exception ex) when (
                ex is FormatException ||
                ex is ArgumentException ||
                ex is OverflowException)
            {
                return -1;
            }

            for (int k = 0; k < data.Length-1;)
            {
                if (!Regex.IsMatch(data[++k], @"^[a-zA-Z]+$"))
                    return -1;
                try
                {
                    var value = int.Parse(data[++k]);
                    if (value < 0)
                        throw new NegativeValuePassedException();
                    value = int.Parse(data[++k]);
                    if (value < 0 || value >= GlobalVariables.numOfHoursInDay)
                        throw new IncorrectTimeException();
                    value = int.Parse(data[++k]);
                    if (value < 0 || value >= GlobalVariables.NumOfMinutesInHour)
                        throw new IncorrectTimeException();
                    value = int.Parse(data[++k]);
                    if (value < 0 || value >= GlobalVariables.numOfHoursInDay)
                        throw new IncorrectTimeException();
                    value = int.Parse(data[++k]);
                    if (value < 0 || value >= GlobalVariables.NumOfMinutesInHour)
                        throw new IncorrectTimeException();
                }
                catch (Exception ex) when (
                    ex is FormatException ||
                    ex is ArgumentException ||
                    ex is OverflowException ||
                    ex is NegativeValuePassedException ||
                    ex is IncorrectTimeException)
                {
                    return -1;
                }
            }
            return 0;
        }

        // Add number of records to trainList
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
                   .Select(s => s.Split(' ', ':'))
                   .ToArray();

                for (int i = 0; i < parsedData.Length; i++)
                {
                    if (checkForInvalidInput(parsedData[i]) != 0)
                        return -1;
                    ltrainNumber = Convert.ToInt32(parsedData[i][0]);

                    for (int k = 0; k < parsedData[0].Length - 1;) 
                    {
                            lstations.Add(parsedData[i][++k]);
                            lkilometers.Add(Convert.ToInt32(parsedData[i][++k]));
                            larrivals.Add(Convert.ToInt32(parsedData[i][++k])* GlobalVariables.NumOfMinutesInHour + Convert.ToInt32(parsedData[i][++k]));
                            ldepartures.Add(Convert.ToInt32(parsedData[i][++k])* GlobalVariables.NumOfMinutesInHour + Convert.ToInt32(parsedData[i][++k]));
                    }
                    Train train = new Train(ltrainNumber, lstations, lkilometers, larrivals, ldepartures);
                    this.addTrain(train);
                    lstations.Clear();
                    lkilometers.Clear();
                    larrivals.Clear();
                    ldepartures.Clear();
                }
            }
            for (int i = 0; i < trainList.Count; i++)
                for(int k = 0; k < trainList[0].getSetStations.Count; k++)
                    if (k != trainList[0].getSetStations.Count - 1)
                        if (checkTimeCorrectness(trainList[i].getSetStations[k + 1].kilometersFromPrevious,
                             trainList[i].getSetStations[k].timeOfDeparture / GlobalVariables.NumOfMinutesInHour,
                             trainList[i].getSetStations[k].timeOfDeparture % GlobalVariables.NumOfMinutesInHour,
                             trainList[i].getSetStations[k + 1].timeOfArrival / GlobalVariables.NumOfMinutesInHour,
                             trainList[i].getSetStations[k + 1].timeOfArrival % GlobalVariables.NumOfMinutesInHour) != 0)
                            return -1;

            return 0;
        }

        // Form string of data for writing to file
        private string formDataForWritingToFile()
        {
            string data = "";
            for (int i = 0; i < trainList.Count; i++)
            {
                data += Convert.ToString(this.trainList[i].getSetTrainNumber);
                foreach (Station st in this.trainList[i].getSetStations)
                {
                    data += ' ' + st.stationName + ' ' + Convert.ToString(st.kilometersFromPrevious) +
                        ' ' + Convert.ToString(st.timeOfArrival / GlobalVariables.NumOfMinutesInHour) + 
                        ':' + Convert.ToString(st.timeOfArrival % GlobalVariables.NumOfMinutesInHour) +
                        ' ' + Convert.ToString(st.timeOfDeparture / GlobalVariables.NumOfMinutesInHour) +
                        ':' + Convert.ToString(st.timeOfDeparture % GlobalVariables.NumOfMinutesInHour) + '\n';
                }
            }
            return data;
        }

        // Write data to file
        public async void writeToFile()
        {
            string sData = formDataForWritingToFile();
            string pathToFile = GlobalVariables.fileNameToSave;
            DirectoryInfo dirInfo = new DirectoryInfo(pathToFile);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            string filename = $"{pathToFile}\\output.txt";

            using (FileStream fstream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(sData);
                await fstream.WriteAsync(array, 0, array.Length);
            }
        }

        // Add trainList to train table
        public void addToDataGrid(ref DataGridView trainTable)
        {
            while (trainTable.Rows.Count > 0)
                trainTable.Rows.Remove(trainTable.Rows[0]);

            foreach (Train train in trainList)
            {
                trainTable.Rows.Add(
                    new object[]
                    {
                        Convert.ToString(train.getSetTrainNumber),
                       train.getSetStations[0].stationName +  " | " +
                       (train.getSetStations[0].timeOfArrival/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':'
                       + (train.getSetStations[0].timeOfArrival%GlobalVariables.NumOfMinutesInHour).ToString("00") + '-' +
                       (train.getSetStations[0].timeOfDeparture/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':'
                       + (train.getSetStations[0].timeOfDeparture%GlobalVariables.NumOfMinutesInHour).ToString("00"),

                       Convert.ToString(train.getSetStations[1].kilometersFromPrevious),

                       train.getSetStations[1].stationName + " | " +
                       (train.getSetStations[1].timeOfArrival/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':' 
                       + (train.getSetStations[1].timeOfArrival%GlobalVariables.NumOfMinutesInHour).ToString("00") + '-' +
                       (train.getSetStations[1].timeOfDeparture/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':' 
                       + (train.getSetStations[1].timeOfDeparture%GlobalVariables.NumOfMinutesInHour).ToString("00"),

                       Convert.ToString(train.getSetStations[2].kilometersFromPrevious),

                       train.getSetStations[2].stationName + " | " +
                       (train.getSetStations[2].timeOfArrival/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':' 
                       + (train.getSetStations[2].timeOfArrival%GlobalVariables.NumOfMinutesInHour).ToString("00") + '-' +
                       (train.getSetStations[2].timeOfDeparture/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':' 
                       + (train.getSetStations[2].timeOfDeparture%GlobalVariables.NumOfMinutesInHour).ToString("00"),

                       Convert.ToString(train.getSetStations[3].kilometersFromPrevious),

                       train.getSetStations[3].stationName + " | " +
                       (train.getSetStations[3].timeOfArrival/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':'
                       + (train.getSetStations[3].timeOfArrival%GlobalVariables.NumOfMinutesInHour).ToString("00") + '-' +
                       (train.getSetStations[3].timeOfDeparture/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':'
                       + (train.getSetStations[3].timeOfDeparture%GlobalVariables.NumOfMinutesInHour).ToString("00"),

                       Convert.ToString(train.getSetStations[4].kilometersFromPrevious),

                       train.getSetStations[4].stationName + " | " +
                       (train.getSetStations[4].timeOfArrival/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':' 
                       + (train.getSetStations[4].timeOfArrival%GlobalVariables.NumOfMinutesInHour).ToString("00") + '-' +
                       (train.getSetStations[4].timeOfDeparture/GlobalVariables.NumOfMinutesInHour).ToString("00") + ':'
                       + (train.getSetStations[4].timeOfDeparture%GlobalVariables.NumOfMinutesInHour).ToString("00")
                    });
            }
        }

    }
}
