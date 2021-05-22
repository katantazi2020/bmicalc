using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
    //This class computes the BMI and has private fields that are 
    //accessible via getters and setters methods
{
   public enum UnitTypes
    {
        Metric,
        American
    }
    class BMICalculator
    {
        private String name = "No Name";
        private double height = 0; // m, feet
        private double weight = 0; //kg, lb
        private UnitTypes unit;

        
        // getter method  - connected to name - field.
       // Method returns value stored in the  field name
       public String GetName()
        {
            return name;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetWeight()
        {
            return weight;
        }

        public UnitTypes GetUnit()
        {
            return unit;
        }
        // Setter Method: changes the value saved in the instance variable name
        //by a new value that comes  to this method  through the parameter value.
        public void SetName( String value)
        {
            //validate value before accepting it!
            if (!String.IsNullOrEmpty( value ))
                name = value;
        }

       
        public void SetHeight(double value)
        {
            if (value >= 0)
                height = value;
        }

       

       
        public void SetWight(double value)
        {
            if (value >= 0)
                weight = value;
        }

        public void SetUnit(UnitTypes value)
        {
            unit = value;

        }

        public String BmiWeightCategory()
        {
            //Calculate BMI
            double bmi = CalculateBMI();
            String stringout = String.Empty;

            if (bmi > 40)
                stringout = "Overweight (Obesity class III)";
            else if (bmi < 40)
                stringout = "OverWeight(obsity class II)";
            else if (bmi < 18.5)
                stringout = "Overwight (Underweight)";
            else if (bmi == 18.5 && (bmi <= 24.9))
                stringout = "Normal Weight";
            else if (bmi == 25.0 && (bmi <= 29.9))
                stringout = "Overweight (Pre-Obesity)";
            else if (bmi == 30.0 && (bmi <= 34.9))
                stringout = ("OverWeight (Obesity class I)");
            else
                stringout = "Underweight";
            
            return stringout;

        }
        public double CalculateBMI()
        {
            double bmi = 0.0;
            if (unit == UnitTypes.American)
            {
                bmi = 703.0 * weight / (height * height);
            }
            else
            {
                bmi = weight / (height * height);
            }
            return bmi;
        }
        public double CalculateWeight(double bmi)
        {
            double weight = 0.0;

            if (unit == UnitTypes.American)
            {
                weight = bmi * (this.GetHeight() * this.GetHeight()) / 703.0;
            }
            else
            {
                weight = bmi * (this.GetHeight() * this.GetHeight());
            }
            return weight;
        }
      

        
    }
}
