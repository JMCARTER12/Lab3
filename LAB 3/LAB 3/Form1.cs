// Grading ID: R8206
// Lab #: 3
// Section: 01
// Due Date: Feb 9, 2020
// This program calculates diameter, surface area, and volume given a radius input from the user
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_3
{
    public partial class LAB3 : Form
    {
        public LAB3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LAB3_Load(object sender, EventArgs e)
        {

        }

        private void DiameterOutput_Click(object sender, EventArgs e)
        {

        }
        // This event handler calculates radius,surface area, and volume through a users given input radius
        private void CalcButton_Click(object sender, EventArgs e)
        {
            double radius; // declaring radius

            radius = double.Parse(RadiusOutput.Text); // User input of radius

            const double diameter = 2; // diameter equation
            double area = Math.PI * Math.Pow (radius,2); // area equation
            double volume = Math.PI * Math.Pow (radius,3); // volume equation

            double DOutput = radius * diameter; // diameter is calculated
            double AOutput = 4 * area; // area is calculated
            double VOutput = (4 * volume) / 3; // volume is calculated

            DiameterOutput.Text = (DOutput.ToString("N")); // output of diamter
            SurfaceAreaOutput.Text = (AOutput.ToString("N")); // output of area
            VolumeOutput.Text = (VOutput.ToString("N")); // output of volume

        }
    }
}
