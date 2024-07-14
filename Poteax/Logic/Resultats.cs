using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Poteax.Models;

namespace Poteax.Logic
{
    public class Resultats
    {
        public static void ProcessBarsData(DataGridView dataGridViewPoteux)
        {
            try
            {
                // Ensure DataGridView has rows
                if (dataGridViewPoteux.Rows.Count == 0)
                {
                    MessageBox.Show("No bars data available in the grid.");
                    return;
                }

                // Collect data from DataGridView into a list of Poteux objects
                List<Poteux> barsDataFromGrid = new List<Poteux>();

                foreach (DataGridViewRow row in dataGridViewPoteux.Rows)
                {
                    if (row.IsNewRow) continue;

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

                // Process data as needed
                // Example processing:
                var messages = new List<string>();

                var loadCaseNumber3 = barsDataFromGrid.Where(L => L.LoadCaseNumber == 3);
                var loadCaseNumberNot3 = barsDataFromGrid.Where(L => L.LoadCaseNumber != 3);

                if (loadCaseNumber3.Any())
                {
                    var ELU = barsDataFromGrid.OrderByDescending(b => b.FX).First();
                    messages.Add($"ELU:\n\nFX: {ELU.FX}\nMY: {ELU.MY}\nMZ: {ELU.MZ}");
                }

                if (loadCaseNumberNot3.Any())
                {
                    var ACC1 = barsDataFromGrid.OrderByDescending(b => b.MY).First();
                    messages.Add($"ACC1:\n\nFX: {ACC1.FX}\nMY: {ACC1.MY}\nMZ: {ACC1.MZ}");
                }

                if (loadCaseNumberNot3.Any())
                {
                    var ACC2 = barsDataFromGrid.OrderByDescending(b => b.MZ).First();
                    messages.Add($"ACC2:\n\nFX: {ACC2.FX}\nMY: {ACC2.MY}\nMZ: {ACC2.MZ}");
                }

                if (loadCaseNumberNot3.Any())
                {
                    var ACC3 = barsDataFromGrid.OrderByDescending(b => b.FX).Last();
                    messages.Add($"ACC3:\n\nFX: {ACC3.FX}\nMY: {ACC3.MY}\nMZ: {ACC3.MZ}");
                }

                if (messages.Any())
                {
                    MessageBox.Show(string.Join("\n\n", messages));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to process bars data: " + ex.Message);
            }
        }
    }
}
