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

                             // Retrieve force data at various points along the beam
                            int numPoints = 100;
                            double increment = 1.0 / numPoints;

                            for (double pos = 0; pos <= 1.0; pos += increment)
                            {
                                IRobotBarForceData forceData = forceServ.Value(BeamNum, cas.Number, pos);

                                Poutre NodePoutreData = new Poutre
                                {
                                    BarNumber = BeamNum,
                                    LoadCaseNumber = cas.Number,
                                    FX = forceData.FX,
                                    FY = forceData.FY,
                                    FZ = forceData.FZ,
                                    MX = forceData.MX,
                                    MY = forceData.MY,
                                    MZ = forceData.MZ,
                                    Position = $"Node - {pos * 100}%"
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
