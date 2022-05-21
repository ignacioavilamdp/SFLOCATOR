using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFLOCATOR
{
    public partial class FrmResults : Form
    {
        //Fields
        private FrmLocator frmLocator;
        private FaultResults faultResults;
        private LineData lineData;

        //Constructor
        public FrmResults(FrmLocator form, FaultResults results, LineData data)
        {
            frmLocator = form;
            faultResults = results;
            lineData = data;
            InitializeComponent();
        }

        //Method triggered by a change in the loop selection combo box event
        private void comboBoxFaultedLoop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = comboBoxFaultedLoop.SelectedItem.ToString();
            ShowResults(selection);
        }

        //Method trigger by the close of the form event
        private void FrmResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLocator.Enabled = true;
        }

        //Method to show the results of the selected loop
        private void ShowResults(string selection)
        {
            LoopResults selectedLoop = null;
            if (selection == "L1-G") selectedLoop = faultResults.L1toGround;
            else if (selection == "L2-G") selectedLoop = faultResults.L2toGround;
            else if (selection == "L3-G") selectedLoop = faultResults.L3toGround;
            else if (selection == "L1-L2") selectedLoop = faultResults.L1toL2;
            else if (selection == "L2-L3") selectedLoop = faultResults.L2toL3;
            else if (selection == "L3-L1") selectedLoop = faultResults.L3toL1;
            else if (selection == "L1-G") selectedLoop = faultResults.L1toGround;
            
            if (selectedLoop != null)
            {
                txtBoxFaultDistanceKm.Text = (selectedLoop.DistancePu * lineData.Length).ToString("G3");
                txtBoxFaultDistancePu.Text = selectedLoop.DistancePu.ToString("G3");
                txtBoxFaultResistance.Text = selectedLoop.FaultResistance.ToString("G3");
            }
        }
    }
}
