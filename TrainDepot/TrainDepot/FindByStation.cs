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
    public partial class FindByStation : Form
    {
        WorkForm parent;
        public FindByStation(ref WorkForm parent)
        {
            this.parent = parent; 
            InitializeComponent();
        }

        private void FindByStation_Load(object sender, EventArgs e)
        {}

        private void submit_Click(object sender, EventArgs e)
        {
            List<int> trainNumbers = parent.trainList.getNumberOfRoutesWithStation(stationName.Text);
            string text = "Number of specific trains: ";
            foreach (int trainNum in trainNumbers)
                text += "\n #" + Convert.ToString(trainNum);
            MessageBox.Show(text);
            this.Close();
        }
    }
}
