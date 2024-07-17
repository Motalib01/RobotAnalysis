using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Poteax.Models;

namespace Poteax.Logic
{
    public class Resultats
    {
        public static List<Poteux> GetBarsData(DataGridView dataGridViewPotauex)
        {
            List<Poteux> barsDataFromGrid = new List<Poteux>();

            try
            {
                foreach (DataGridViewRow row in dataGridViewPotauex.Rows)
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
            }
            catch (Exception)
            {

                MessageBox.Show("problem here the data");
            }

            return barsDataFromGrid;
        }

        public static List<ResultData> ProcessBarsData(List<Poteux> poteuxes)
        {
            var results = new List<ResultData>();

            var ELU = poteuxes.Where(b => b.LoadCaseNumber == 3)
                              .OrderByDescending(b => b.FX)
                              .FirstOrDefault();

            if (ELU != null)
                results.Add(new ResultData("ELU", ELU.FX / 1000, ELU.MY / 1000, ELU.MZ / 1000));

            var ACC1 = poteuxes.Where(b => b.LoadCaseNumber != 1
                                        && b.LoadCaseNumber != 2
                                        && b.LoadCaseNumber != 3
                                        && b.LoadCaseNumber != 5)
                               .OrderBy(b => Math.Abs(b.MY))
                               .FirstOrDefault();

            if (ACC1 != null)
                results.Add(new ResultData("ACC1", ACC1.FX / 1000, ACC1.MY / 1000, ACC1.MZ / 1000));

            var ACC2 = poteuxes.Where(b => b.LoadCaseNumber != 1
                                        && b.LoadCaseNumber != 2
                                        && b.LoadCaseNumber != 3
                                        && b.LoadCaseNumber != 5)
                               .OrderBy(b => Math.Abs(b.MZ))
                               .FirstOrDefault();

            if (ACC2 != null)
                results.Add(new ResultData("ACC2", ACC2.FX / 1000, ACC2.MY / 1000, ACC2.MZ / 1000));

            var ACC3 = poteuxes.Where(b => b.LoadCaseNumber != 1
                                        && b.LoadCaseNumber != 2
                                        && b.LoadCaseNumber != 3
                                        && b.LoadCaseNumber != 5)
                               .OrderBy(b => b.FX)
                               .LastOrDefault();

            if (ACC3 != null)
                results.Add(new ResultData("ACC3", ACC3.FX/1000, ACC3.MY / 1000, ACC3.MZ / 1000));

            return results;

        }
    }
}
