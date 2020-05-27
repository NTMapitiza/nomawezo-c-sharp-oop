using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class frmCalculator : Form
    {
        double FirstNumber;
        string Operation;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "1";
            }
            else
            {
                txtResults.Text = txtResults.Text + "1";
            }
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "2";
            }
            else
            {
                txtResults.Text = txtResults.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "3";
            }
            else
            {
                txtResults.Text = txtResults.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "4";
            }
            else
            {
                txtResults.Text = txtResults.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "5";
            }
            else
            {
                txtResults.Text = txtResults.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "6";
            }
            else
            {
                txtResults.Text = txtResults.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "7";
            }
            else
            {
                txtResults.Text = txtResults.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "8";
            }
            else
            {
                txtResults.Text = txtResults.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "9";
            }
            else
            {
                txtResults.Text = txtResults.Text + "9";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResults.Text = txtResults.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            txtResults.Text = "0";
            Operation = "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            txtResults.Text = "0";
            Operation = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            txtResults.Text = "0";
            Operation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            txtResults.Text = "0";
            Operation = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Text = "0";
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            txtResults.Text = txtResults.Text + ".";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            double sqRoot = FirstNumber * FirstNumber;
            txtResults.Text = Convert.ToString(sqRoot);
        }

        private void btnOneByX_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            txtResults.Text = Convert.ToString(1 / FirstNumber);
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
           
            txtResults.Text = Convert.ToString(FirstNumber / -1);
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();

            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtResults.Text);
            Result = operations.GetResults(FirstNumber, Operation, SecondNumber);
           
            txtResults.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
        }
    }
 }

