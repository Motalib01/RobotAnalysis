using RobotOM;
using System;
using System.Windows.Forms;
using Poteax.Logic;
using System.Collections.Generic;
using Poteax.Models;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Poteax.Forms
{
    public partial class Importe : Form
    {
        private IRobotApplication robApp;
        private Retrieve Retrieve = new Retrieve();
        
        
        public Importe()
        {
            InitializeComponent();
            InitializeRobot();
            
        }
        private void InitializeRobot()
        {
            try
            {
                robApp = new RobotApplication();
                robApp.Visible = 1; 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize Robot: " + ex.Message);
            }
        }

        private void ImporterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Call the method in Retrieve to retrieve bars data
                Retrieve.RetrieveSelectedBarsData(robApp);

                // Bind the retrieved data to dataGridViewPoteux
                dataGridViewPoteux.DataSource = Retrieve.BarsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve and display bars data: " + ex.Message);
            }
        }

        private void ResultatsBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewPoteux.Rows.Count == 0)
            {
                MessageBox.Show("No bars data available in the grid.");
                return;
            }

            List<Poteux> barsDataFromGrid = new List<Poteux>();

            foreach (DataGridViewRow row in dataGridViewPoteux.Rows)
            {
                if (row.IsNewRow) continue;

                // Assuming the DataGridView columns match the Poteux properties
                int loadCaseNumber = Convert.ToInt32(row.Cells["LoadCaseNumber"].Value);
                double fx = Convert.ToDouble(row.Cells["FX"].Value);
                double my = Convert.ToDouble(row.Cells["MY"].Value);
                double mz = Convert.ToDouble(row.Cells["MZ"].Value);

                Poteux poteux = new Poteux
                {
                    LoadCaseNumber = loadCaseNumber,
                    FX = fx,
                    MY = my,
                    MZ = mz
                };

                barsDataFromGrid.Add(poteux);
            }
            var messages = new List<string>();

            var LoadCaseNumber = barsDataFromGrid.Where(L => L.LoadCaseNumber==3);
            var LoadCaseNumber2 = barsDataFromGrid.Where(L => L.LoadCaseNumber!=3);
            if (LoadCaseNumber.Any())
            {
                var ELU = barsDataFromGrid.OrderByDescending(b => b.FX).First();
                messages.Add($"ELU:\n\nFX: {ELU.FX}\nMY: {ELU.MY}\nMZ: {ELU.MZ}");
            }
            if (LoadCaseNumber2.Any()) 
            {
                var ACC1 = barsDataFromGrid.OrderByDescending(b => b.MY).First();
                messages.Add($"ACC1:\n\nFX: {ACC1.FX}\nMY: {ACC1.MY}\nMZ: {ACC1.MZ}");
            }
            if(LoadCaseNumber2.Any())
            {
                var ACC2 = barsDataFromGrid.OrderByDescending(b => b.MZ).First();
                messages.Add($"ACC2:\n\nFX: {ACC2.FX}\nMY: {ACC2.MY}\nMZ: {ACC2.MZ}");
            }
            if(LoadCaseNumber2.Any())
            {
                var ACC3 = barsDataFromGrid.OrderByDescending(b => b.FX).Last();
                messages.Add($"ACC3:\n\nFX: {ACC3.FX}\nMY: {ACC3.MY}\nMZ: {ACC3.MZ}");
            }
            if (messages.Any())
            {
                MessageBox.Show(string.Join("\n\n", messages));
                MessageBox.Show(DataGrid);
            }
        }
    }
}
