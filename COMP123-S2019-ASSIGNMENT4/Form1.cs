﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_ASSIGNMENT4
{
    /*Manal Hagos
     301027317
     22/7/2019
     BMI calculator
     form1 functions*/

    public partial class BMICalculatorApp : Form
    {

        private bool _isMetric; 

        public BMICalculatorApp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// input height , weight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(Height.Text);
            double weight = Convert.ToDouble(Weight.Text);
         /// calculate bmi with displaying message
            double BMI = weight * (_isMetric == true ? 1 : 703) / Math.Pow(height, 2);
            result.Text = BMI.ToString("f3");
            if(BMI>=30)
            {
                scaleTextbox.Text = "obese";
                resultTextbox.Text = " 30 or greater";

            }
            else if(BMI >=25)
            {
                scaleTextbox.Text = "Overweight";
                resultTextbox.Text = " between 25 and 29.9";
            }
            else if(BMI >= 18.5)
            {
                scaleTextbox.Text = "Normal";
                resultTextbox.Text = "between 18.5 and 24.9 ";
            }
            else
            {
                scaleTextbox.Text = "Underweight";
                resultTextbox.Text = "less than 18.5";
            }

        }
        /// <summary>
        /// if the user choose imperial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            _isMetric = false;

        }

        private void BMICalculatorApp_Load(object sender, EventArgs e)
        {
            MetricButton.Select();
            _isMetric = true;
        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            _isMetric = true;
        }

       
        // to accept just number , . input 
        private void Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| char.IsControl (e.KeyChar)||char.IsPunctuation(e.KeyChar)) 
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
        // to accept just number , . input 
        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// SplashScreen will appear for few seconds 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Tick(object sender, EventArgs e)
        {
            
            SplashScreen.Enabled = true;
        }

        
    }
}
