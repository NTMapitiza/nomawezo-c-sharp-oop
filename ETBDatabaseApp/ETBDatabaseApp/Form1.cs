using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETBDatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblInvoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblInvoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eTBDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'eTBDatabaseDataSet.tblInvoice' table. You can move, or remove it, as needed.
                this.tblInvoiceTableAdapter.Fill(this.eTBDatabaseDataSet.tblInvoice);
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Database error # " + ex.Number + 
                    ": " + ex.Message, ex.GetType().ToString());
            }
            
        }

        private void tblInvoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
