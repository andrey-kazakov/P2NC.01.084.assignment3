using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3_AndreiKazakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int weight, height;

            try
            {
                weight = Int32.Parse(WeightInputBox.Text);
                height = Int32.Parse(HeightInputBox.Text);

                if (weight < 1 || height < 1)
                {
                    throw new FormatException("value should be >= 1");
                }
            }
            catch (FormatException)
            {
                OutputBox.Text = "Please enter correct values";
                WeightInputBox.Focus();
                return;
            }

            float heightInMeters = height / (float) 100;
            float bmi = weight / (heightInMeters * heightInMeters);

            string status = "normal";
            if (bmi < 18.5)
            {
                status = "underweight";
            }
            else if (bmi > 25)
            {
                status = "overweight";
            }

            OutputBox.Lines = new string[] { $"BMI: {bmi}", $"Status: {status}" };
            WeightInputBox.Focus();
        }
    }
}
