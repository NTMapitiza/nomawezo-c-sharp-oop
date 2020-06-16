using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDrive
{
    public partial class frmEstimate : Form
    {
        public frmEstimate()
        {
            InitializeComponent();
        }

        private void frmEstimate_Load(object sender, EventArgs e)
        {
            grpFoundations.Visible = false;
            lblLength.Visible = false;
            txtLength.Visible = false;
            lblLengthMetres.Visible = false;
            lblWidth.Visible = false;
            txtWidth.Visible = false;
            lblWidthMetres.Visible = false;
            lblPounds.Visible = false;
            txtPounds.Visible = false;
            lblEuros.Visible = false;
            txtEuros.Visible = false;
            cmdCalculate.Visible = false;
            cmdClear.Visible = false;
            lblOutput.Visible = false;
        }
        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                DialogResult dialog = MessageBox.Show(name + " not entered", "Reminder",
                MessageBoxButtons.OK,                   
                MessageBoxIcon.Exclamation);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsPresentDimensions(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                DialogResult dialog = MessageBox.Show(name + " not entered.\n" + "Please enter dimensions", "Reminder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                if (number <= 0)
                {
                    MessageBox.Show(name + " must be greater than 0.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show(name + " must be a numeric value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private bool IsValidData()
        {
            return
                IsPresent(txtExchangeRate, "Exchange Rate") &&
                IsDecimal(txtExchangeRate, "Exchange Rate") &&

                IsPresent(txtBrickPrice, "Brick Price") &&
                IsDecimal(txtBrickPrice, "Brick Price") &&

                IsPresent(txtConcretePrice, "Concrete Price") &&
                IsDecimal(txtConcretePrice, "Concrete Price") &&

                IsPresent(txtTarmacPrice, "Tarmac Price") &&
                IsDecimal(txtTarmacPrice, "Tarmac Price") &&

                IsPresent(txtGravelPrice, "Gravel Price") &&
                IsDecimal(txtGravelPrice, "Gravel Price");
        }

        private bool IsValidDimensions()
        {
            return
                IsPresentDimensions(txtLength, "Length") &&
                IsDecimal(txtLength, "Length") &&

                IsPresentDimensions(txtWidth, "Width") &&
                IsDecimal(txtWidth, "Width");
        }

        private void MakeInvisible()
        {
            lblFromPoundRate.Visible = false;
            txtExchangeRate.Visible = false;
            lblToEuroRate.Visible = false;
            lblPerSquareMetre.Visible = false;
            txtBrickPrice.Visible = false;
            txtConcretePrice.Visible = false;
            txtTarmacPrice.Visible = false;
            txtGravelPrice.Visible = false;
            cmdStart.Visible = false;
        }
        private void MakeVisible()
        {
            grpFoundations.Visible = true;
            lblLength.Visible = true;
            txtLength.Visible = true;
            lblLengthMetres.Visible = true;
            lblWidth.Visible = true;
            txtWidth.Visible = true;
            lblWidthMetres.Visible = true;
            lblPounds.Visible = true;
            txtPounds.Visible = true;
            lblEuros.Visible = true;
            txtEuros.Visible = true;
            cmdCalculate.Visible = true;
            cmdClear.Visible = true;
            lblFormTitle.ForeColor = Color.Green;
        }
        private void cmdStart_Click(object sender, EventArgs e)
        {
            
            decimal pounds = 1m;
            bool returnValue = false;
            txtPounds.Text = Convert.ToString(pounds);
            txtEuros.Text = txtExchangeRate.Text;
            try
            {
                if (IsValidData())
                {
                    returnValue = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (returnValue == true)
            {
                MakeInvisible();
                MakeVisible();
            }
            lblOutput.Visible = true;
            lblOutput.ForeColor = Color.Green;
            lblOutput.BackColor = Color.Green;

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            string name = "";
            string type = "";
            decimal poundTotal = 0m;
            decimal euroTotal = 0m;
            bool returnValue = false;
            try
            {
                if (IsValidDimensions())
                {
                    if (rdoStandard.Checked)
                    {
                        name = "Standard";
                        
                    }
                    else
                    {
                        if (rdoExtraDeep.Checked)
                        {
                            name = "Extra Deep";
                        }
                    }

                    if (rdoBrick.Checked)
                    {
                        type = "Brick";
                        poundTotal = (Convert.ToDecimal(txtLength.Text ) * Convert.ToDecimal(txtWidth.Text )) * Convert.ToDecimal(txtBrickPrice.Text);
                        txtPounds.Text = Convert.ToString(Math.Round(poundTotal, 2));
                    }
                    else
                    {
                        if (rdoConcrete.Checked)
                        {
                            type = "Concrete";
                            poundTotal = (Convert.ToDecimal(txtLength.Text) * Convert.ToDecimal(txtWidth.Text)) * Convert.ToDecimal(txtConcretePrice.Text);
                            txtPounds.Text = Convert.ToString(Math.Round(poundTotal, 2));
                        }
                        else
                        {
                            if (rdoTarmac.Checked)
                            {
                                type = "Tarmac";
                                poundTotal = (Convert.ToDecimal(txtLength.Text) * Convert.ToDecimal(txtWidth.Text)) * Convert.ToDecimal(txtTarmacPrice.Text);
                                txtPounds.Text = Convert.ToString(Math.Round(poundTotal, 2));
                            }
                            else
                            {
                                if (rdoGravel.Checked)
                                {
                                    type = "Gravel";
                                    poundTotal = (Convert.ToDecimal(txtLength.Text) * Convert.ToDecimal(txtWidth.Text)) * Convert.ToDecimal(txtGravelPrice.Text);
                                    txtPounds.Text = Convert.ToString(Math.Round(poundTotal, 2));
                                }
                            }
                        }
                    }
                    euroTotal = poundTotal * Convert.ToDecimal(txtExchangeRate.Text);
                    txtEuros.Text = Convert.ToString(Math.Round(euroTotal, 2));
                    returnValue = true;
                }
                lblOutput.ForeColor = Color.Black;
                lblOutput.BackColor = Color.White;
                lblOutput.Text = $"{type } selected with { name } foundation";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
