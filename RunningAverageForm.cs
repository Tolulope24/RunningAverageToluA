using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tolulope Adebayo
 * Created on: 11-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program keeps accepting input (a mark between 0 and 100) and calculates the average
*/
namespace RunningAverageToluA
{
    public partial class frmRunningAverage : Form
    {
        public frmRunningAverage()
        {
            InitializeComponent();
        } 
            int Sum;
            int NumTotal;
            int Average;
        private void button1_Click(object sender, EventArgs e)
        {
            int Number;
            // Get the Number from the text box
            Number = int.Parse(txtAverage.Text);
            // Increment the total number
            NumTotal = NumTotal + 1;
            //Get the sum
            Sum = Number + Sum;
            // Get the Average
            Average = Sum / NumTotal;
            //Show Average
            this.lblAnswer.Text = "The Average is: " + Average;
            // Show Message box
              if ( Number == -1)
              {
                MessageBox.Show("Running Average Ended", "Running Average");
                this.btnCalculate.Enabled = false;
                this.txtAverage.Visible = false;
              }
               
            
            
        }
    }
}
