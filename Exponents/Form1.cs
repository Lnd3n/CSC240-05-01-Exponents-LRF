using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Landen Fowler
 * Date: 10/23/2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int INP, SqINP, CuINP;
            // INPUT
            INP = Convert.ToInt32(InputTextBox.Text);
            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            SqINP = Square(INP);
            SqOutLabel.Text = SqINP.ToString();
            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            CuINP = Cube(INP);
            CuOutLabel.Text = CuINP.ToString();
            // OUTPUT
            // set the output to visible
            SquaredLabel.Visible = true;
            CubedLabel.Visible = true;
            SqOutLabel.Visible = true;
            CuOutLabel.Visible = true;
            // turn the Go button off
            GoButton.Enabled = false;
        }

        public int Square(int num)
        {
            // we will create this code in class
            int ans = num * num;
            return ans;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            int ans = num * num * num;
            return ans;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            InputTextBox.Text = " ";
            SqOutLabel.Text = " ";
            CuOutLabel.Text= " ";
            // turn the output to invisible
            SquaredLabel.Visible = false;
            CubedLabel.Visible = false;
            SqOutLabel.Visible = false;
            CuOutLabel.Visible = false;
            // turn the Go button back on
            GoButton.Enabled = true;
        }

    }
}
