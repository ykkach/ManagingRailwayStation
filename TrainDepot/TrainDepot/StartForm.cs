using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace TrainDepot
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void OpenNew_Click(object sender, EventArgs e)
        {
            WorkForm workform = new WorkForm();
            TrainList trainList = new TrainList();

            workform.Show();
            this.Close();
        }

        private void OpenFromFile_Click(object sender, EventArgs e)
        {
            WorkForm workform = new WorkForm();
            TrainList trainList = new TrainList();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    TrainList.getList().parseDataFromFile(sr.ReadToEnd());
                    // save and parse data (sr.ReadToEnd())
                    //
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
            workform.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
