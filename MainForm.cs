using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //An instance of the BMI calculator
        private BMICalculator bmiCalc = new BMICalculator();
        
        //Initialize Methods
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            
        }

        private void InitializeGUI()
        {
            this.Text = "The Body Mass Calculator";
            // Input controls
            rdbMetricUnitInput.Checked = true;
            rdbUsUnitInput.Checked = false;
           lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";

            // Clear user input Text Boxes
            txtHeightInput.Text = String.Empty;
            txtWeightInput.Text = String.Empty;
            txtYourNameInput.Text = String.Empty;
            
            // clear display out labels
            lblBmiResults.Text = String.Empty;
            lblWeightResults.Text = String.Empty;
            


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Read and validate input
            bool ok = ReadInputBMI();

            // Display the results if the input is okey
            if (ok)
            {
                DisplayResults();
            }
        }
        private void rdbMetricUnitInput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMetricUnitInput.Checked) //if false - unchecked
            {
                //update height and weight to metric
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                
                //Setting the unit weight
                bmiCalc.SetUnit(UnitTypes.Metric);

                

            }
        }

        private void rdbUsUnitInput_CheckedChanged(object sender, EventArgs e)
        {
            // If you select the US Measurement button is selected
            if (rdbUsUnitInput.Checked)
            {
                // Labels changed to us measurements
                lblHeight.Text = "Height (ft)";
                lblWeight.Text = "Weight (lbs)";

                // Setting object to American Measurement
                bmiCalc.SetUnit(UnitTypes.American);
            }
        }

        private bool ReadHeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(textBox4.Text, out outValue);
            if (ok)
            {
                if (outValue > 0) //Height can not be zero or negative
                {
                    if (bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        bmiCalc.SetHeight(outValue * 12.00); // Covert feet to inches
                    }
                    else
                    {
                        bmiCalc.SetHeight(outValue / 100); // Convert cm to m
                    }
                }

                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid Height Value", "Error");
            return ok;
        }

        private bool ReadInputBMI()
        {
            // When user selects Metric Measurement
            if (rdbMetricUnitInput.Checked)
            {
                //Set object type to metric
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
            else
            {
                bmiCalc.SetUnit(UnitTypes.American);
            }
            ReadName(); // Read, validate and process User Name Input
            
            // Return success if both methods were succesful
            return ReadHeight() && ReadWeight();
        }

        private void ReadName()
        {
            if (String.IsNullOrEmpty(txtYourNameInput.Text.Trim()))
            {
                //set default name
                bmiCalc.SetName("No name");
            }
            else
            {
                bmiCalc.SetName(txtYourNameInput.Text.Trim());
            }


        }
        public bool ReadWeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtWeightInput.Text.Trim(), out outValue);
            if (ok && (outValue > 0))
            {
                bmiCalc.SetWight(outValue);
            }
            else
            {
                MessageBox.Show("Invalid Weight Value", "Error");
                return false;
            }
            return ok;

        }




        private void DisplayResults()
        {
            lblBmiResults.Text = bmiCalc.CalculateBMI().ToString("f2");
            lblWeightResults.Text = bmiCalc.BmiWeightCategory().ToString();

            groupBox1.Text = "Results for" + bmiCalc.GetName();

            if (bmiCalc.GetUnit() == UnitTypes.American)
            {
                lblBmiResults.Text = "Normal weight should  be between " + bmiCalc.CalculateWeight(18.50).ToString("f2") + "and" + bmiCalc.CalculateWeight(24.9).ToString("f2") + "lbs";
            }
            else
            {
                lblBmiResults.Text = "Normal weight should  be between " + bmiCalc.CalculateWeight(18.50).ToString("f2") + "and" + bmiCalc.CalculateWeight(24.9).ToString("f2") + "kg";
            }
            

        }

        private void txtHeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

 