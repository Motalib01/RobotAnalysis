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

namespace Poteax.Controls
{
    public partial class ImportControl : UserControl
    {
        private IRobotApplication robApp;
        private Retrieve Retrieve = new Retrieve();
        public ImportControl(IRobotApplication robotApplication)
        {
            InitializeComponent();
            robApp = robotApplication;
            LoadData();
        }
        
        private void LoadData()
        {
            try
            {
                // Call the method in Retrieve to retrieve bars data
                Retrieve.RetrieveSelectedBarsData(robApp);

                // Bind the retrieved data to dataGridViewPoteux
                dataGridViewImportBar.DataSource = Retrieve.BarsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve and display bars data: " + ex.Message);
            }
        }
    }
}
