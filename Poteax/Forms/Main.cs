using Poteax.Controls;
using Poteax.Logic;
using RobotOM;
using System.Windows.Forms;
using System;

namespace Poteax.Forms
{
    public partial class Main : Form
    {
        private IRobotApplication robApp;
        private ImportControl _importControl;
        private ResultatsControl resultatsControl;
        private DataGridView dataGridViewImportBar;



        public Main()
        {
            InitializeComponent();
            InitializeRobot();
            _importControl = new ImportControl(robApp, dataGridViewImportBar);  // Pass dataGridViewImportBar to ImportControl
            resultatsControl = new ResultatsControl(_importControl);  // Pass dataGridViewImportBar to ResultatsControl
        }

        private void InitializeRobot()
        {
            try
            {
                robApp = new RobotApplication();
                
                robApp.Interactive = 1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize Robot: " + ex.Message);
            }
        }
       

        private void LoadControl(Control control)
        {
            MainContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            MainContentPanel.Controls.Add(control);
        }

        private void ImporteBtn_Click(object sender, EventArgs e)
        {
            _importControl = new ImportControl(robApp, dataGridViewImportBar);
            LoadControl(_importControl);
        }

        private void ResultatsBtn_Click(object sender, EventArgs e)
        {

            if (_importControl != null)
            {
                resultatsControl = new ResultatsControl(_importControl);
                LoadControl(resultatsControl);
            }
            else
            {
                MessageBox.Show("Please import data first.");
            }
        }
    }
}
