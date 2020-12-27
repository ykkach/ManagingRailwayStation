
//
// Main form designed for managing list of trains.
// 

using System;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace TrainDepot
{
    public partial class WorkForm : Form
    {
        // 

        string OPERATION_ON_EMPTY_LIST = "Operation can not be completed on empty list.";
        string SAVE_TO_FILE_SUCCESS = "Data has been successfully saved to file.";
        string READING_FILE_SUCCESS_MESSAGE = "Data from file has been read successfully.";
        string READING_FILE_ERROR_MESSAGE = "Invalid data in file, please check data correctness.";

        public TrainList trainList = TrainList.getList(); 
        public WorkForm()
        {
            InitializeComponent();
        }

        // If there is records in current table, ask
        // if user want to save them.
        // Then clear table.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trainList.trainList.Count != 0)
            {
                DialogResult saveFile = 
                    MessageBox.Show($"Create new table without saving current?", 
                                        "Save table", 
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                if (saveFile == DialogResult.Yes)
                {
                    trainList.clearList();
                    trainList.addToDataGrid(ref trainDataTable);
                }
                else if (saveFile == DialogResult.No)
                {
                    trainList.writeToFile();
                    MessageBox.Show(SAVE_TO_FILE_SUCCESS,
                    "Save file",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    trainList.clearList();
                    trainList.addToDataGrid(ref trainDataTable);
                }
            }
        }

        // If there is records in current table, ask
        // if user want to save them.
        // Check data correctness and fill table
        // with data from file aftewards.
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    if (trainList.trainList.Count > 0)
                    {
                        DialogResult clearData =
                            MessageBox.Show($"Create new file without saving current?",
                                                "Open file",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                        if (clearData == DialogResult.Yes)
                        {
                            trainList.clearList();
                            if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                            {
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                            else
                            {
                                MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                                            "Invalid input. Please, check if your file stores correct data.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                trainList.clearList();
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                        }
                        else if (clearData == DialogResult.No)
                        {
                            trainList.writeToFile();
                            MessageBox.Show(SAVE_TO_FILE_SUCCESS, 
                                "Save file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            trainList.clearList();
                            if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                            {
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                            else
                            {
                                MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                                            "Invalid input. Please, check if your file stores correct data.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                trainList.clearList();
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                        }
                    }
                    else
                    {
                        if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                        {
                            trainList.addToDataGrid(ref trainDataTable);
                        }
                        else
                        {
                            MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                                        "Invalid input. Please, check if your file stores correct data.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            trainList.clearList();
                            trainList.addToDataGrid(ref trainDataTable);
                        }
                    }
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n {ex.StackTrace} ");
            }
        }

        // Save table to file output.txt.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.writeToFile();
                MessageBox.Show(SAVE_TO_FILE_SUCCESS,
                                "Save file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }


        // Add new record.
        // New window for data input will pop up.
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkForm workFormCopy = this;
            AddTrain newTrain = new AddTrain(ref workFormCopy, ref trainDataTable);
            newTrain.Show();
        }

        // Sort records by average speed of each train.
        private void sortBySpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.sortBySpeed();
                trainList.addToDataGrid(ref trainDataTable);
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Sort records by name of initial station.
        private void sortByStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.sortByFirstStation();
                trainList.addToDataGrid(ref trainDataTable);
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Display train number of each train,
        // that satisfies particular statement.
        // In this case station name will
        // be considered.
        private void findNumberOfSpecificTrainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                WorkForm workFormCopy = this;
                FindByStation newForm = new FindByStation(ref workFormCopy);
            newForm.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Display train number of each train,
        // that satisfies particular statement.
        // In this case one station and arrival
        // time will be considered.
        private void findTrainByTimeOfArrivalToTheStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                WorkForm workFormCopy = this;
                FindByStationAndArrivalTime newForm = new FindByStationAndArrivalTime(ref workFormCopy);
                newForm.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Display train number of each train,
        // that satisfies particular statement.
        // In this case one station and departure
        // time will be considered.
        private void findTrainByTimeOfDepartureFromTheStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                WorkForm workFormCopy = this;
                FindByStationAndDepartureTime newForm = new FindByStationAndDepartureTime(ref workFormCopy);
                newForm.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Group records with similar intermediate
        // and final station names.
        private void groupByLastStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.groupByStationNames();
                trainList.addToDataGrid(ref trainDataTable);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // If there is records in current table, ask
        // if user want to save them.
        // Then clear table.
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (trainList.trainList.Count != 0)
            {
                DialogResult saveFile =
                    MessageBox.Show($"Create new file without saving current?",
                                        "Save file",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                if (saveFile == DialogResult.Yes)
                {
                    trainList.clearList();
                    trainList.addToDataGrid(ref trainDataTable);
                }
                else if (saveFile == DialogResult.No)
                {
                    trainList.writeToFile();
                    MessageBox.Show(SAVE_TO_FILE_SUCCESS);
                    trainList.clearList();
                    trainList.addToDataGrid(ref trainDataTable);
                }
            }
        }

        // If there is records in current table, ask
        // if user want to save them.
        // Check data correctness and fill table
        // with data from file aftewards.
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    if (trainList.trainList.Count > 0)
                    {
                        DialogResult clearData =
                            MessageBox.Show($"Create new file without saving current?",
                                                "Open file",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                        if (clearData == DialogResult.Yes)
                        {
                            trainList.clearList();
                            if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                            {
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                            else
                            {
                                MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                                            "Invalid input. Please, check if your file stores correct data.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                trainList.clearList();
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                        }
                        else if (clearData == DialogResult.No)
                        {
                            trainList.writeToFile();
                            MessageBox.Show(SAVE_TO_FILE_SUCCESS,
                                "Save file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            trainList.clearList();
                            if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                            {
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                            else
                            {
                                MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                                            "Invalid input. Please, check if your file stores correct data.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                trainList.clearList();
                                trainList.addToDataGrid(ref trainDataTable);
                            }
                        }
                    }
                    else
                    {
                        if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                        {
                            trainList.addToDataGrid(ref trainDataTable);
                        }
                        else
                        {
                            MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                                        "Invalid input. Please, check if your file stores correct data.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            trainList.clearList();
                            trainList.addToDataGrid(ref trainDataTable);
                        }
                    }
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n {ex.StackTrace} ");
            }
            trainList.addToDataGrid(ref trainDataTable);
        }

        // Save table to file output.txt.
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.writeToFile();
                MessageBox.Show(SAVE_TO_FILE_SUCCESS, 
                                "Data saved",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                         "Empty List",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            }
        }

        // Add new record.
        // New window for data input will pop up.
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WorkForm workFormCopy = this;
            AddTrain newTrain = new AddTrain(ref workFormCopy, ref trainDataTable);
            newTrain.Show();
        }

        // Open up new window to contact with developer.
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailSender sendEmailForm = new EmailSender();
            sendEmailForm.Show();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            trainDataTable.Columns[0].Width = 100;
            trainDataTable.Columns[1].Width = 180;
            trainDataTable.Columns[2].Width = 60;
            trainDataTable.Columns[3].Width = 160;
            trainDataTable.Columns[4].Width = 60;
            trainDataTable.Columns[5].Width = 160;
            trainDataTable.Columns[6].Width = 60;
            trainDataTable.Columns[7].Width = 160;
            trainDataTable.Columns[8].Width = 60;
            trainDataTable.Columns[9].Width = 180;
        }
        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        { }
        private void trainDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
    }
}
