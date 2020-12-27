using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TrainDepot
{
    /// <summary>
    /// Find train by one of its stations
    /// </summary>
    public partial class FindByStation : Form
    {
        WorkForm mainForm;
        public FindByStation(ref WorkForm parent)
        {
            this.mainForm = parent; 
            InitializeComponent();
        }

        // Check for valid input and
        // find trains that match condition:
        // there is one or more station in the route
        // of that matches passed string
        private void submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(stationName.Text) || !Regex.IsMatch(stationName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid station name entered. Please, try again", "Invalid data", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            List<int> trainNumbers = mainForm.trainList.getTrainsByStation(stationName.Text);
            if (trainNumbers.Count == 0)
            {
                MessageBox.Show("Neither of trains has matched", "No match", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                this.Close();
                return;
            }
            string text = "Number of specific trains: ";
            foreach (int trainNum in trainNumbers)
                text += "\n #" + Convert.ToString(trainNum);
            MessageBox.Show(text, "Matched trains", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void FindByStation_Load(object sender, EventArgs e)
        { }
    }
}
