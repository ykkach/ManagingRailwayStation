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
    public partial class FindByStationAndDepartureTime : Form
    {
        WorkForm parent;
        public FindByStationAndDepartureTime(ref WorkForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int timeInMinutes = Convert.ToInt32(time.Value.ToString("HH:mm").Split(':')[0]) * 60 + Convert.ToInt32(time.Value.ToString("HH:mm").Split(':')[1]); ;
            List<int> trainsMatched = parent.trainList.getTrainsByStationDeparture(stationName.Text, timeInMinutes);
            string text = "Train matched: ";
            foreach (int train in trainsMatched)
                text += " #" + Convert.ToString(train);
            MessageBox.Show(text);
            this.Close();
        }
    }
}
