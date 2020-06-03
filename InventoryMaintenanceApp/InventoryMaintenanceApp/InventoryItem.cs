using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace InventoryMaintenanceApp
{
    public partial class frmInventoryItem : Form
    {
        public static int itemToMain;
        public static string descToMain;
        public static decimal priceToMain;

        frmInventoryMain main = new frmInventoryMain();
        public frmInventoryItem()
        {
            InitializeComponent();
        }

        private Inventory inventory = null;

        public Inventory GetNewInventory()
        {
            this.ShowDialog();
            return inventory;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    inventory = new Inventory(Convert.ToInt32(txtItem.Text), txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
                    itemToMain = Convert.ToInt32(txtItem.Text);
                    descToMain = txtDescription.Text;
                    priceToMain = Convert.ToDecimal(txtPrice.Text); 
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A format exception has occured. Please check all entries.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occured. Please enter smaller values.", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n"
                    + ex.StackTrace, "Exception");
            }

            this.Close();

        }
        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsValidData()
        {
            return
                IsPresent(txtItem, "Item number") &&
                IsPresent(txtDescription, "Item description") &&
                IsPresent(txtPrice, "Item price") &&
                IsDecimal(txtPrice, "Item price");
        }
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void frmInventoryItem_Load(object sender, EventArgs e)
        {
            BindDataList();
        }

        private void BindDataList()
        {
            ArrayList array = new ArrayList();
            array.Add("Scotts");
            array.Add("Fleming");
            array.Add("Walmart");

            cmbManufacturer.DataSource = array;
            cmbManufacturer.SelectedIndex = 0;
        }
        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
