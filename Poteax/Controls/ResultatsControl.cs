using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraEditors;
using Poteax.Logic;
using Poteax.Models;

namespace Poteax.Controls
{
    public partial class ResultatsControl : UserControl
    {
        
        private ImportControl _importControl;


        public ResultatsControl(ImportControl importControl)
        {
            InitializeComponent();
            this.Load += new EventHandler(LoadResultats);
            _importControl = importControl;
        }

       

        private void LoadResultats(object sender, EventArgs e)
        {
            List<Poteux> Poteuxs = _importControl.GetData();
            
            var results = new List<ResultData>();

            var ELU = Poteuxs.Where(b => b.LoadCaseNumber == 3)
                              .OrderByDescending(b => b.FX)
                              .FirstOrDefault();

            if (ELU != null)
                results.Add(new ResultData("ELU", ELU.FX / 1000, ELU.MY / 1000, ELU.MZ / 1000));

            var ACC1 = Poteuxs.Where(b => b.LoadCaseNumber != 1
                                        && b.LoadCaseNumber != 2
                                        && b.LoadCaseNumber != 3
                                        && b.LoadCaseNumber != 5)
                               .OrderBy(b => Math.Abs(b.MY))
                               .FirstOrDefault();

            if (ACC1 != null)
                results.Add(new ResultData("ACC1", ACC1.FX / 1000, ACC1.MY / 1000, ACC1.MZ / 1000));

            var ACC2 = Poteuxs.Where(b => b.LoadCaseNumber != 1
                                        && b.LoadCaseNumber != 2
                                        && b.LoadCaseNumber != 3
                                        && b.LoadCaseNumber != 5)
                               .OrderBy(b => Math.Abs(b.MZ))
                               .FirstOrDefault();

            if (ACC2 != null)
                results.Add(new ResultData("ACC2", ACC2.FX / 1000, ACC2.MY / 1000, ACC2.MZ / 1000));

            var ACC3 = Poteuxs.Where(b => b.LoadCaseNumber != 1
                                        && b.LoadCaseNumber != 2
                                        && b.LoadCaseNumber != 3
                                        && b.LoadCaseNumber != 5)
                               .OrderBy(b => b.FX)
                               .LastOrDefault();

            if (ACC3 != null)
                results.Add(new ResultData("ACC3", ACC3.FX / 1000, ACC3.MY / 1000, ACC3.MZ / 1000));

            BindingSource binding = new BindingSource();
            binding.DataSource = results;
            dataGridViewRes.DataSource = binding;

            dataGridViewRes.CellFormatting += dataGridViewRes_CellFormatting;

        }
        private void dataGridViewRes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is one of the columns to be formatted
            if (dataGridViewRes.Columns[e.ColumnIndex].Name == "FX" ||
                dataGridViewRes.Columns[e.ColumnIndex].Name == "MY" ||
                dataGridViewRes.Columns[e.ColumnIndex].Name == "MZ")
            {
                // Format the value to two decimal places
                if (e.Value != null)
                {
                    e.Value = string.Format("{0:N2}", Convert.ToDecimal(e.Value));
                    e.FormattingApplied = true;
                }
            }
        }

    }
}
