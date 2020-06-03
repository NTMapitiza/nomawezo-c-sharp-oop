using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenanceApp
{
    public partial class frmInventoryMain : Form
    {
        Inventory inventory = new Inventory();
        public frmInventoryMain()
        {
            InitializeComponent();
        }

        List<Inventory> inventories = new List<Inventory>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInventoryItem inventoryItem = new frmInventoryItem();
            Inventory inventory = inventoryItem.GetNewInventory();
            if (inventory != null)
            {
                inventories.Add(inventory);
                FillInventoryListBox();
            }
        }

        private void frmInventoryMain_Load(object sender, EventArgs e)
        {
            FillInventoryListBox();
        }

        private void FillInventoryListBox()
        {
            lstInventory.Items.Clear();
            //List<Inventory> inventories = new List<Inventory>();
            //new Inventory { Item = 3245649, Description = "ForkLift", Price = 12.95m };
            foreach (Inventory inventory in inventories)
            {
                lstInventory.Items.Add(inventory.GetDisplayText());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstInventory.SelectedIndex;
            if (i != -1)
            {
                Inventory inventory = inventories[i];
                string message = "Are you sure you want to delete "
                    + inventory.Description + "?";

                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    inventories.Remove(inventory);
                    FillInventoryListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
