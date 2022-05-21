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
    public partial class FrmLocator : Form
    {
        //Fields
        private LineData lineData;
        private FaultData faultData;
        private FaultResults faultResults;
        private FrmResults frmResults;

        //Constructor
        public FrmLocator()
        {
            InitializeComponent();
            InitializeControls();
        }

        //Method triggered by the "Calculate" button click event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Obtains the fault and line data from the user controls
            GetFaultData();
            GetLineData();

            //Computes line to ground loops
            LoopResults resultL1toGround = Solver.SolveLineToGround(lineData, faultData.L1Current, faultData.L1Voltage, faultData.NCurrent, faultData.NCurrent);
            LoopResults resultL2toGround = Solver.SolveLineToGround(lineData, faultData.L2Current, faultData.L2Voltage, faultData.NCurrent, faultData.NCurrent);
            LoopResults resultL3toGround = Solver.SolveLineToGround(lineData, faultData.L3Current, faultData.L3Voltage, faultData.NCurrent, faultData.NCurrent);

            //Computes line to line loops
            LoopResults resultL1toL2 = Solver.SolveLineToLine(lineData, faultData.L1Current, faultData.L1Voltage, faultData.L2Current, faultData.L2Voltage, faultData.L1Current);
            LoopResults resultL2toL3 = Solver.SolveLineToLine(lineData, faultData.L2Current, faultData.L2Voltage, faultData.L3Current, faultData.L3Voltage, faultData.L2Current);
            LoopResults resultL3toL1 = Solver.SolveLineToLine(lineData, faultData.L3Current, faultData.L3Voltage, faultData.L1Current, faultData.L1Voltage, faultData.L3Current);

            //Updates the fault results
            faultResults = new FaultResults(resultL1toGround, resultL2toGround, resultL3toGround, resultL1toL2, resultL2toL3, resultL3toL1);

            //Shows the results
            this.Enabled = false;
            frmResults = new FrmResults(this, faultResults, lineData);
            frmResults.Show();
        }

        //Method triggered by the change in line values combo box
        private void comboBoxLineValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLineValues.SelectedItem.ToString() == "Primary")
                groupBoxTransformers.Visible = false;
            else
                groupBoxTransformers.Visible = true;
        }

        //Method to obtain fault data from user controls
        private void GetFaultData()
        {
            double l1CurrentMag = Convert.ToDouble(txtBoxL1CurrentMag.Text);
            double l2CurrentMag = Convert.ToDouble(txtBoxL2CurrentMag.Text);
            double l3CurrentMag = Convert.ToDouble(txtBoxL3CurrentMag.Text);
            double nCurrentMag = Convert.ToDouble(txtBoxNCurrentMag.Text);
            double l1CurrentArg = Convert.ToDouble(txtBoxL1CurrentArg.Text);
            double l2CurrentArg = Convert.ToDouble(txtBoxL2CurrentArg.Text);
            double l3CurrentArg = Convert.ToDouble(txtBoxL3CurrentArg.Text);
            double nCurrentArg = Convert.ToDouble(txtBoxNCurrentArg.Text);

            double l1VoltageMag = Convert.ToDouble(txtBoxL1VoltageMag.Text);
            double l2VoltageMag = Convert.ToDouble(txtBoxL2VoltageMag.Text);
            double l3VoltageMag = Convert.ToDouble(txtBoxL3VoltageMag.Text);
            double l1VoltageArg = Convert.ToDouble(txtBoxL1VoltageArg.Text);
            double l2VoltageArg = Convert.ToDouble(txtBoxL2VoltageArg.Text);
            double l3VoltageArg = Convert.ToDouble(txtBoxL3VoltageArg.Text);

            faultData = new FaultData(l1CurrentMag, l2CurrentMag, l3CurrentMag, nCurrentMag, l1CurrentArg, l2CurrentArg, l3CurrentArg, nCurrentArg, l1VoltageMag, l2VoltageMag, l3VoltageMag, l1VoltageArg, l2VoltageArg, l3VoltageArg);
        }

        //Method to obtain line data from user controls
        private void GetLineData()
        {
            double length = Convert.ToDouble(txtBoxLineLength.Text);
            double kCT = Convert.ToDouble(txtBoxCTRatedPrimaryCurrent.Text) / Convert.ToDouble(txtBoxCTRatedSecondaryCurrent.Text);
            double kPT = Convert.ToDouble(txtBoxPTRatedPrimaryVoltage.Text) / Convert.ToDouble(txtBoxPTRatedSecondaryVoltage.Text);
            double k0r = Convert.ToDouble(txtBoxLineKr.Text);
            double k0x = Convert.ToDouble(txtBoxLineKx.Text);
            double z1Arg = Convert.ToDouble(txtBoxLineZ1Arg.Text);
            double z1Mag;
            if (comboBoxLineValues.SelectedItem.ToString() == "Primary")
                z1Mag = Convert.ToDouble(txtBoxLineZ1Mag.Text);
            else
                z1Mag = Convert.ToDouble(txtBoxLineZ1Mag.Text) * kPT / kCT;

            lineData = new LineData(z1Mag, z1Arg, k0r, k0x, length, kCT, kPT);
        }

        //Method to initialize the text boxes
        private void InitializeControls()
        {
            txtBoxL1CurrentMag.Text = "520";
            txtBoxL1CurrentArg.Text = "-83.1";
            txtBoxL2CurrentMag.Text = "1183";
            txtBoxL2CurrentArg.Text = "177.0";
            txtBoxL3CurrentMag.Text = "16988";
            txtBoxL3CurrentArg.Text = "-32.5";
            txtBoxNCurrentMag.Text = "16305";
            txtBoxNCurrentArg.Text = "-35.9";

            txtBoxL1VoltageMag.Text = "120000";
            txtBoxL1VoltageArg.Text = "-86.1";
            txtBoxL2VoltageMag.Text = "118970";
            txtBoxL2VoltageArg.Text = "153.5";
            txtBoxL3VoltageMag.Text = "31488";
            txtBoxL3VoltageArg.Text = "-5.6";

            txtBoxCTRatedPrimaryCurrent.Text = "600";
            txtBoxCTRatedSecondaryCurrent.Text = "1";
            txtBoxPTRatedPrimaryVoltage.Text = "132000";
            txtBoxPTRatedSecondaryVoltage.Text = "110";

            txtBoxLineLength.Text = "7";
            txtBoxLineZ1Mag.Text = "3.97";
            txtBoxLineZ1Arg.Text = "81.2";
            txtBoxLineKr.Text = "3.151";
            txtBoxLineKx.Text = "1.37";

            comboBoxLineValues.SelectedIndex = 0;
        }

        //Method to update the line data
        public void UpdateLineData(LineData newLineData)
        {
            lineData = newLineData;
        }

    }
}
