using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainDepot
{
    public partial class AddTrain : Form
    {
        string ADDING_TRAIN_SUCCESS_MESSAGE = "Information about new train added successfully.";
        string ADDING_TRAIN_ERROR_MESSAGE = "Invalid input, please try again.";
        WorkForm parent;
        DataGridView trainDataTable;
        string data;
        public AddTrain(ref WorkForm wForm, ref DataGridView dataTable)
        {
            parent = wForm;
            trainDataTable = dataTable;
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //
            //  Check for invalid input
            //

            data = number.Text + ' ' +
                stName1.Text + ' ' + km1.Text + ' ' + hours1.GetItemText(hours1.SelectedItem) + ' ' + min1.GetItemText(min1.SelectedItem) + ' ' + hours6.GetItemText(hours6.SelectedItem) + ' ' + min6.GetItemText(min6.SelectedItem) + ' ' +
                stName2.Text + ' ' + km2.Text + ' ' + hours2.GetItemText(hours2.SelectedItem) + ' ' + min2.GetItemText(min2.SelectedItem) + ' ' + hours7.GetItemText(hours7.SelectedItem) + ' ' + min6.GetItemText(min7.SelectedItem) + ' ' +
                stName3.Text + ' ' + km3.Text + ' ' + hours3.GetItemText(hours3.SelectedItem) + ' ' + min3.GetItemText(min3.SelectedItem) + ' ' + hours8.GetItemText(hours8.SelectedItem) + ' ' + min6.GetItemText(min8.SelectedItem) + ' ' +
                stName4.Text + ' ' + km4.Text + ' ' + hours4.GetItemText(hours4.SelectedItem) + ' ' + min4.GetItemText(min4.SelectedItem) + ' ' + hours9.GetItemText(hours9.SelectedItem) + ' ' + min6.GetItemText(min9.SelectedItem) + ' ' +
                stName5.Text + ' ' + km5.Text + ' ' + hours5.GetItemText(hours5.SelectedItem) + ' ' + min5.GetItemText(min5.SelectedItem) + ' ' + hours10.GetItemText(hours10.SelectedItem) + ' ' + min6.GetItemText(min10.SelectedItem);
            label1.Text = data;
            if (parent.trainList.parseDataSingleRecord(data) == 0)
                MessageBox.Show(ADDING_TRAIN_SUCCESS_MESSAGE);
            else
                MessageBox.Show(ADDING_TRAIN_ERROR_MESSAGE);
            parent.trainList.addToDataGrid(ref trainDataTable);
            this.Close();
        }
    }
}
