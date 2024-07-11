using RobotOM;
using System;
using System.Windows.Forms;
using Poteax.Logic;

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
    }
}
