using Poteax.Logic;
using RobotOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Poutres.Controls
{
    public partial class ImportControlBeam : UserControl
    {
        private IRobotApplication robApp;
        private RetrieveBeam retrieve;
        public ImportControlBeam(IRobotApplication robotApplication, DataGridView dataGridViewImportBeam)
        {
            InitializeComponent();
            robApp = robotApplication;
            this.retrieve = new RetrieveBeam();
            this.Load += new EventHandler(LoadData);
        }
        private void LoadData(object sender, EventArgs e)
        {
            try
            {
                // Call the method in Retrieve to retrieve bars data
                retrieve.RetrieveSelectedBarsData(robApp);

                // Bind the retrieved data to dataGridViewImportBar
                dataGridViewImportBeam.DataSource = null; // Clear previous binding
                dataGridViewImportBeam.DataSource = retrieve.BeamData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve and display beams data: " + ex.Message);
            }
        }
    }
}
