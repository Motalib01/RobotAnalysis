using RobotOM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Poutres.Models;

namespace Poteax.Logic
{
    public class RetrieveBeam
    {
        public List<Poutre> BeamData { get; private set; }

        public void RetrieveSelectedBarsData(IRobotApplication robApp)
        {
            try
            {
                if (robApp == null)
                {
                    throw new ArgumentNullException(nameof(robApp), "IRobotApplication instance is not initialized.");
                }

                // Initialize force server
                IRobotBarForceServer forceServ = robApp.Project.Structure.Results.Bars.Forces;

                // Get the selection of bars
                IRobotSelection selection = robApp.Project.Structure.Selections.Get(IRobotObjectType.I_OT_BAR);

                if (selection.Count > 0)
                {
                    BeamData = new List<Poutre>();

                    for (int i = 1; i <= selection.Count; i++)
                    {
                        // Get selected bar number
                        int BeamNum = selection.Get(i);

                        // Get bar object
                        IRobotBar bar = (IRobotBar)robApp.Project.Structure.Bars.Get(BeamNum);

                        // Get the collection including all load cases
                        IRobotCaseCollection casCol = robApp.Project.Structure.Cases.GetAll();

                        for (int j = 1; j <= casCol.Count; j++)
                        {
                            // Get load case
                            IRobotCase cas = casCol.Get(j);

                            // Get force value at the start node of the bar (0.0)
                            IRobotBarForceData startNodeData = forceServ.Value(BeamNum, cas.Number, 0.0);

                            // Get force value at the end node of the bar (1.0)
                            IRobotBarForceData endNodeData = forceServ.Value(BeamNum, cas.Number, 1.0);

                            List<string> positions = new List<string>();
                            for (int p = 1; p <= 100; p++)
                            {
                                positions.Add($"Position {p}");
                            }

                            // Create and add a Poutre object to the list
                            foreach (string position in positions)
                            {
                                Poutre NodePoutreData = new Poutre
                                {
                                    BarNumber = BeamNum,
                                    LoadCaseNumber = cas.Number,
                                    FX = startNodeData.FX,
                                    FY = startNodeData.FY,
                                    FZ = startNodeData.FZ,
                                    MX = startNodeData.MX,
                                    MY = startNodeData.MY,
                                    MZ = startNodeData.MZ,
                                    Position = $"Node - {position}"
                                };
                                BeamData.Add(NodePoutreData); 
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Beams selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve selected Beams data: " + ex.Message);
            }
        }
    }
}
