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
        private Retrieve Retrieve = new Retrieve();
        private ImportControl importControl;
        private DataGridView dataGridViewImportBar;

        public Main()
        {
            InitializeComponent();
            InitializeRobot();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Initialize your DataGridView here
            dataGridViewImportBar = new DataGridView();
            // Optionally set properties like Dock, Size, etc.
            dataGridViewImportBar.Dock = DockStyle.Fill;
            // Add any necessary columns
            dataGridViewImportBar.Columns.Add("LoadCaseNumber", "Load Case Number");
            dataGridViewImportBar.Columns.Add("FX", "FX");
            dataGridViewImportBar.Columns.Add("MY", "MY");
            dataGridViewImportBar.Columns.Add("MZ", "MZ");
            // Add to MainContentPanel or another container if necessary
            MainContentPanel.Controls.Add(dataGridViewImportBar);
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

        private void LoadControl(Control control)
        {
            MainContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            MainContentPanel.Controls.Add(control);
        }

        private void ImporteBtn_Click(object sender, EventArgs e)
        {
            importControl = new ImportControl(robApp);
            LoadControl(importControl);
        }

        private void ResultatsBtn_Click(object sender, EventArgs e)
        {
            // Check if dataGridViewImportBar is initialized and has data
            if (dataGridViewImportBar == null || dataGridViewImportBar.Rows.Count == 0)
            {
                MessageBox.Show("No data available in dataGridViewImportBar.");
                return;
            }

            // Pass dataGridViewImportBar to ResultatsControl
            LoadControl(new ResultatsControl(dataGridViewImportBar));
        }
    }
}
