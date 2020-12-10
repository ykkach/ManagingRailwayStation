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
            if (number.Text == "" ||
                stName1.Text == "" || stName2.Text == "" || stName3.Text == "" || stName4.Text == "" || stName5.Text == "" ||
                km1.Text == "" || km2.Text == "" || km3.Text == "" || km4.Text == "" || km5.Text == "")
            {
                MessageBox.Show($"Please, fill all fields.");
                return;
            }
            data = number.Text + ' ' +
                stName1.Text + ' ' + km1.Text + ' ' + timearr1.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr1.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep1.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep1.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName2.Text + ' ' + km2.Text + ' ' + timearr2.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr2.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep2.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep2.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName3.Text + ' ' + km3.Text + ' ' + timearr3.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr3.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep3.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep3.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName4.Text + ' ' + km4.Text + ' ' + timearr4.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr4.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep4.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep4.Value.ToString("HH:mm").Split(':')[1] + ' ' +
                stName5.Text + ' ' + km5.Text + ' ' + timearr5.Value.ToString("HH:mm").Split(':')[0] + ' ' + timearr5.Value.ToString("HH:mm").Split(':')[1] + ' ' + timedep5.Value.ToString("HH:mm").Split(':')[0] + ' ' + timedep5.Value.ToString("HH:mm").Split(':')[1];
            if (parent.trainList.parseDataSingleRecord(data) != 0)
                MessageBox.Show(ADDING_TRAIN_ERROR_MESSAGE);
            parent.trainList.addToDataGrid(ref trainDataTable);
            this.Close();
        }

    }
}
