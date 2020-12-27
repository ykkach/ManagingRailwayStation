using System;
using System.Windows.Forms;

namespace TrainDepot
{

    /// <summary>
    /// Add new record to table, previously
    /// checked for invalid input
    /// </summary>
    public partial class AddTrain : Form
    {
        string ADDING_TRAIN_SUCCESS_MESSAGE = "Information about new train added successfully.";
        string ADDING_TRAIN_ERROR_MESSAGE = "Invalid input, please try again.";
        WorkForm parent;
        DataGridView trainDataTable;

        public AddTrain(ref WorkForm wForm, ref DataGridView dataTable)
        {
            parent = wForm;
            trainDataTable = dataTable;
            InitializeComponent();
        }

        //find out whether passed string is empty or not
        bool isEmpty(string str)
        {
            return String.IsNullOrEmpty(str);
        }

        // Form and parse string, add new record to list,
        // add newly added record to table
        private void Add_Click(object sender, EventArgs e)
        {
            if (isEmpty(number.Text) ||
                isEmpty(stName1.Text) ||
                isEmpty(stName2.Text) ||
                isEmpty(stName3.Text) ||
                isEmpty(stName4.Text) ||
                isEmpty(stName5.Text) ||
                isEmpty(km1.Text) ||
                isEmpty(km2.Text) ||
                isEmpty(km3.Text) ||
                isEmpty(km4.Text) ||
                isEmpty(km5.Text))
            {
                MessageBox.Show($"Please, fill all fields.",
                    "Empty fields",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return;
            }
            if (parent.trainList.parseDataSingleRecord(formDataString()) != 0)
            {
                MessageBox.Show(ADDING_TRAIN_ERROR_MESSAGE, 
                    "Invalid input",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }
            parent.trainList.addToDataGrid(ref trainDataTable);
            this.Close();
        }

        // form string from data in fields
        string formDataString()
        {
            return number.Text + ' ' +
                stName1.Text + ' ' + km1.Text + ' ' + timearr1.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr1.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep1.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep1.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName2.Text + ' ' + km2.Text + ' ' + timearr2.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr2.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep2.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep2.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName3.Text + ' ' + km3.Text + ' ' + timearr3.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr3.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep3.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep3.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName4.Text + ' ' + km4.Text + ' ' + timearr4.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr4.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep4.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep4.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName5.Text + ' ' + km5.Text + ' ' + timearr5.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr5.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep5.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep5.Value.ToString("HH:mm").Split(':')[1];
        }

    }
}
