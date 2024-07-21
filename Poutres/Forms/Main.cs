using Poutres.Controls;
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

namespace Poutres.Forms
{
    public partial class Main : Form
    {
        private IRobotApplication robApp;
        private ImportControlBeam _importControl;
        private DataGridView dataGridViewImportBeam;

        public Main()
        {
            InitializeComponent();
            InitializeRobot();
            _importControl = new ImportControlBeam(robApp, dataGridViewImportBeam);
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

        private void importeBtn_Click(object sender, EventArgs e)
        {
            _importControl = new ImportControlBeam(robApp, dataGridViewImportBeam);
            LoadControl(_importControl);
        }
    }
}
