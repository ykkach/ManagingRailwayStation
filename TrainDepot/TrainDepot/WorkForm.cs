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
        public TrainList trainList = TrainList.getList(); 
        public WorkForm()
        {
            InitializeComponent();
            /*
            trainDataTable.ColumnCount = ;
            trainDataTable.ColumnHeadersVisible = true;
            trainDataTable.RowHeadersVisible = false;
            trainDataTable.Columns[0].Name = "Initial array";
            trainDataTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            trainDataTable.ColumnHeadersDefaultCellStyle.Font =
                new Font(trainDataTable.Font, FontStyle.Bold);
            trainDataTable.ShowEditingIcon = false;
            trainDataTable.AutoResizeRows(
DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            trainDataTable.AllowUserToAddRows = false;*/
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    trainList.parseDataFromFile(sr.ReadToEnd());
                    // save and parse data (sr.ReadToEnd())
                    //
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

                TrainList.getList().addToDataGrid(ref trainDataTable);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sortByAverageSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sortByInitialStationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void routesWithParticularStationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WorkForm_Load(object sender, EventArgs e)
        {}

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkForm workFormCopy = this;
            AddTrain newTrain = new AddTrain(ref workFormCopy, ref trainDataTable);
            newTrain.Show();
        }

        private void sortBySpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
