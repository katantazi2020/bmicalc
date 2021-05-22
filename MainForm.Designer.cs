namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.Label();
            this.txtYourNameInput = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeightInput = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeightInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUsUnitInput = new System.Windows.Forms.RadioButton();
            this.rdbMetricUnitInput = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblWeightResults = new System.Windows.Forms.Label();
            this.lblBmiResults = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtHeightInputInches = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(59, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Your Name";
            // 
            // txtYourNameInput
            // 
            this.txtYourNameInput.Location = new System.Drawing.Point(162, 27);
            this.txtYourNameInput.Name = "txtYourNameInput";
            this.txtYourNameInput.Size = new System.Drawing.Size(510, 26);
            this.txtYourNameInput.TabIndex = 1;
            this.txtYourNameInput.Text = " ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(60, 89);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(87, 20);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height(cm)";
            // 
            // txtHeightInput
            // 
            this.txtHeightInput.Location = new System.Drawing.Point(162, 86);
            this.txtHeightInput.Name = "txtHeightInput";
            this.txtHeightInput.Size = new System.Drawing.Size(100, 26);
            this.txtHeightInput.TabIndex = 3;
            this.txtHeightInput.TextChanged += new System.EventHandler(this.txtHeightInput_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(59, 125);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(86, 20);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Weight(kg)";
            // 
            // txtWeightInput
            // 
            this.txtWeightInput.Location = new System.Drawing.Point(162, 122);
            this.txtWeightInput.Name = "txtWeightInput";
            this.txtWeightInput.Size = new System.Drawing.Size(100, 26);
            this.txtWeightInput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(324, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(179, 48);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUsUnitInput);
            this.groupBox1.Controls.Add(this.rdbMetricUnitInput);
            this.groupBox1.Location = new System.Drawing.Point(579, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rdbUsUnitInput
            // 
            this.rdbUsUnitInput.AutoSize = true;
            this.rdbUsUnitInput.Location = new System.Drawing.Point(9, 60);
            this.rdbUsUnitInput.Name = "rdbUsUnitInput";
            this.rdbUsUnitInput.Size = new System.Drawing.Size(157, 24);
            this.rdbUsUnitInput.TabIndex = 1;
            this.rdbUsUnitInput.TabStop = true;
            this.rdbUsUnitInput.Text = "US unit (foot, lbs)";
            this.rdbUsUnitInput.UseVisualStyleBackColor = true;
            this.rdbUsUnitInput.CheckedChanged += new System.EventHandler(this.rdbUsUnitInput_CheckedChanged);
            // 
            // rdbMetricUnitInput
            // 
            this.rdbMetricUnitInput.AutoSize = true;
            this.rdbMetricUnitInput.Location = new System.Drawing.Point(9, 30);
            this.rdbMetricUnitInput.Name = "rdbMetricUnitInput";
            this.rdbMetricUnitInput.Size = new System.Drawing.Size(166, 24);
            this.rdbMetricUnitInput.TabIndex = 0;
            this.rdbMetricUnitInput.TabStop = true;
            this.rdbMetricUnitInput.Text = "Metric Unit (kg cm)";
            this.rdbMetricUnitInput.UseVisualStyleBackColor = true;
            this.rdbMetricUnitInput.CheckedChanged += new System.EventHandler(this.rdbMetricUnitInput_CheckedChanged);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.textBox5);
            this.grpResults.Controls.Add(this.lblWeightResults);
            this.grpResults.Controls.Add(this.lblBmiResults);
            this.grpResults.Controls.Add(this.textBox4);
            this.grpResults.Location = new System.Drawing.Point(87, 302);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(691, 120);
            this.grpResults.TabIndex = 8;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results for";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(501, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 26);
            this.textBox5.TabIndex = 3;
            // 
            // lblWeightResults
            // 
            this.lblWeightResults.AutoSize = true;
            this.lblWeightResults.Location = new System.Drawing.Point(26, 73);
            this.lblWeightResults.Name = "lblWeightResults";
            this.lblWeightResults.Size = new System.Drawing.Size(124, 20);
            this.lblWeightResults.TabIndex = 2;
            this.lblWeightResults.Text = "Weght Category";
            // 
            // lblBmiResults
            // 
            this.lblBmiResults.AutoSize = true;
            this.lblBmiResults.Location = new System.Drawing.Point(26, 31);
            this.lblBmiResults.Name = "lblBmiResults";
            this.lblBmiResults.Size = new System.Drawing.Size(76, 20);
            this.lblBmiResults.TabIndex = 1;
            this.lblBmiResults.Text = "Your BMI";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(501, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 26);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtHeightInputInches
            // 
            this.txtHeightInputInches.Location = new System.Drawing.Point(311, 83);
            this.txtHeightInputInches.Name = "txtHeightInputInches";
            this.txtHeightInputInches.Size = new System.Drawing.Size(86, 26);
            this.txtHeightInputInches.TabIndex = 9;
            this.txtHeightInputInches.Tag = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.txtHeightInputInches);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeightInput);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeightInput);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtYourNameInput);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtYourNameInput;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeightInput;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeightInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUsUnitInput;
        private System.Windows.Forms.RadioButton rdbMetricUnitInput;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblWeightResults;
        private System.Windows.Forms.Label lblBmiResults;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtHeightInputInches;
    }
}

