﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TrainDepot
{
    public partial class FindByStationAndArrivalTime : Form
    {
        /// <summary>
        /// Find train by one of its stations and arrival time
        /// </summary>
        WorkForm mainForm;
        public FindByStationAndArrivalTime(ref WorkForm parent)
        {
            InitializeComponent();
            this.mainForm = parent;
        }

        // Check for valid input and
        // find trains that match condition:
        // there is one or more station in the route
        // of the train that matches passed string and
        // its arrival time is similar to dateTimePicker value
        private void submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(stationName.Text) || !Regex.IsMatch(stationName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid station name entered. Please, try again", "Invalid data", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            int timeInMinutes = Convert.ToInt32(time.Value.ToString("HH:mm").Split(':')[0]) * 60 + Convert.ToInt32(time.Value.ToString("HH:mm").Split(':')[1]);
            List<int> trainsMatched = mainForm.trainList.getTrainsByStationArrival(stationName.Text, Convert.ToInt32(timeInMinutes));
            if (trainsMatched.Count == 0)
            {
                MessageBox.Show("Neither of trains has matched", "No match", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                this.Close();
                return;
            }
            string text = "Train matched: ";
            foreach (int train in trainsMatched)
                text += " #" + Convert.ToString(train);
            MessageBox.Show(text, "Matched trains", MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk);
            this.Close();
        }

    }
}
