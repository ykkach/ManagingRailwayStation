using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace TrainDepot
{
    public partial class WorkForm : Form
    {
        string OPERATION_ON_EMPTY_LIST = "Operation can not be completed on empty list.";
        string SAVE_TO_FILE_SUCCESS = "Data has been successfully saved to file.";
        string READING_FILE_SUCCESS_MESSAGE = "Data from file has been read successfully.";
        string READING_FILE_ERROR_MESSAGE = "Invalid data in file, please check data correctness.";

        public TrainList trainList = TrainList.getList(); 
        public WorkForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    if (trainList.trainList.Count > 0)
                    {
                        DialogResult clearData =
                            MessageBox.Show($"Create new table?",
                                                "Open file",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                        if (clearData == DialogResult.Yes)
                        { }
                        else if (clearData == DialogResult.No)
                        {
                            trainList.clearList();
                            trainList.addToDataGrid(ref trainDataTable);
                        }
                    }
                    if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                    {}
                    else
                    {
                        MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                            "Invalid input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        trainList.clearList();
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                trainList.addToDataGrid(ref trainDataTable);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.writeToFile();
                MessageBox.Show(SAVE_TO_FILE_SUCCESS);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                        "Empty List",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkForm workFormCopy = this;
            AddTrain newTrain = new AddTrain(ref workFormCopy, ref trainDataTable);
            newTrain.Show();
        }

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

        private void sortByStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.sortByFStation();
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

        private void groupByLastStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainList.trainList.Count == 0)
                    throw new InvalidOperationException(OPERATION_ON_EMPTY_LIST);
                trainList.groupByLStation();
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    if (trainList.parseDataFromFile(sr.ReadToEnd()) == 0)
                    {}
                    else
                    {
                        MessageBox.Show(READING_FILE_ERROR_MESSAGE,
                             "Invalid input",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                        trainList.clearList();
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

                trainList.addToDataGrid(ref trainDataTable);
            }
        }

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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WorkForm workFormCopy = this;
            AddTrain newTrain = new AddTrain(ref workFormCopy, ref trainDataTable);
            newTrain.Show();
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
