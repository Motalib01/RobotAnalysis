using RobotOM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Poteax.Models;

namespace Poteax.Logic
{
    public class Retrieve
    {
        public List<Poteux> BarsData { get; private set; }

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
                    BarsData = new List<Poteux>();

                    for (int i = 1; i <= selection.Count; i++)
                    {
                        // Get selected bar number
                        int barNum = selection.Get(i);

                        // Get bar object
                        IRobotBar bar = (IRobotBar)robApp.Project.Structure.Bars.Get(barNum);

                        // Get the collection including all load cases
                        IRobotCaseCollection casCol = robApp.Project.Structure.Cases.GetAll();

                        for (int j = 1; j <= casCol.Count; j++)
                        {
                            // Get load case
                            IRobotCase cas = casCol.Get(j);

                            // Get force value at the start node of the bar (0.0)
                            IRobotBarForceData startNodeData = forceServ.Value(barNum, cas.Number, 0.0);

                            // Get force value at the end node of the bar (1.0)
                            IRobotBarForceData endNodeData = forceServ.Value(barNum, cas.Number, 1.0);

                            // Create and add a Poteux object to the list
                            Poteux startNodePoteuxData = new Poteux
                            {
                                BarNumber = barNum,
                                LoadCaseNumber = cas.Number,
                                FX = startNodeData.FX,
                                FY = startNodeData.FY,
                                FZ = startNodeData.FZ,
                                MX = startNodeData.MX,
                                MY = startNodeData.MY,
                                MZ = startNodeData.MZ,
                                Position = "Start Node"
                            };
                            BarsData.Add(startNodePoteuxData);

                            // Create and add a Poteux object to the list for end node
                            Poteux endNodePoteuxData = new Poteux
                            {
                                BarNumber = barNum,
                                LoadCaseNumber = cas.Number,
                                FX = endNodeData.FX,
                                FY = endNodeData.FY,
                                FZ = endNodeData.FZ,
                                MX = endNodeData.MX,
                                MY = endNodeData.MY,
                                MZ = endNodeData.MZ,
                                Position = "End Node"
                            };
                            BarsData.Add(endNodePoteuxData);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No bars selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve selected bars data: " + ex.Message);
            }
        }
    }
}
