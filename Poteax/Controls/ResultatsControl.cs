using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Poteax.Logic;
using Poteax.Models;

namespace Poteax.Controls
{
    public partial class ResultatsControl : UserControl
    {
        private DataGridView dataGridViewImportBar; // Declare the DataGridView

        public ResultatsControl(DataGridView dataGridViewImportBar)
        {
            InitializeComponent();
            this.dataGridViewImportBar = dataGridViewImportBar;
            LoadResultats();
            
        }

        

        private void LoadResultats()
        {
            try
            {
                // Check if dataGridViewImportBar is valid
                if (dataGridViewImportBar == null)
                {
                    MessageBox.Show("dataGridViewImportBar is not initialized.");
                    return;
                }

                // Proceed with data processing
                Resultats.ProcessBarsData(dataGridViewImportBar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load results: " + ex.Message);
            }
        }
    }
}
