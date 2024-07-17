using Poteax.Logic;
using Poteax.Models;
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
        private Retrieve retrieve;
        public ImportControl(IRobotApplication robotApplication, DataGridView dataGridViewImportBar)
        {
            InitializeComponent();
            robApp = robotApplication;
            this.retrieve = new Retrieve();
            this.Load += new EventHandler(LoadData);
        }
        
        private void LoadData(object sender, EventArgs e)
        {
            try
            {
                // Call the method in Retrieve to retrieve bars data
                retrieve.RetrieveSelectedBarsData(robApp);

                // Bind the retrieved data to dataGridViewImportBar
                dataGridViewImportBar.DataSource = null; // Clear previous binding
                dataGridViewImportBar.DataSource = retrieve.BarsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve and display bars data: " + ex.Message);
            }
        }
        public List<Poteux> GetData()
        {
            var data = new List<Poteux>();
            foreach (DataGridViewRow row in dataGridViewImportBar.Rows)
            {
                if (row.DataBoundItem != null)
                {
                    data.Add((Poteux)row.DataBoundItem);
                }
            }
            return data;
        }
    }
}
