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
using System.Collections;
using System.Data.SqlClient;

namespace CRUDApplication
{
    public partial class frmSearchForm : Form
    {
        public frmSearchForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
        }

        private static string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MMABooks.mdf;" +
            "Integrated Security=True;Connect Timeout=30";
        private static SqlConnection connection = new SqlConnection(connectionString);

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
                 
            BindDataList();

        }
        private void BindDataList()
        {
            ArrayList array = new ArrayList();
            array.Add("ProductCode");
            array.Add("Description");
            array.Add("UnitPrice");
            array.Add("OnHandQuantity");

            cmbProductFields.DataSource = array;
            cmbProductFields.SelectedIndex = 0;

            ArrayList array1 = new ArrayList();
            array1.Add("=");
            array1.Add("<");
            array1.Add(">");
            array1.Add("<=");
            array1.Add(">=");

            cmbSearchOperator.DataSource = array1;
            cmbSearchOperator.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectStatement = "";
            if (txtValue.Text != "")
            {
                if (cmbProductFields.Text == "ProductCode" || cmbProductFields.Text == "Description")
                {
                    selectStatement = "SELECT * FROM Products WHERE "
                        + cmbProductFields.Text + " " + cmbSearchOperator.Text + " '" + txtValue.Text + "' ";
                }
                else
                {
                    selectStatement = "SELECT * FROM Products WHERE "
                        + cmbProductFields.Text + " " + cmbSearchOperator.Text + " " + txtValue.Text;
                }
                connection.Open();
                DataSet MMABooksDataSet = new DataSet();
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                SqlDataAdapter sda = new SqlDataAdapter(selectCommand);
                sda.Fill(MMABooksDataSet);
                productsDataGridView.DataSource = MMABooksDataSet.Tables[0];
                connection.Close();
            }
            else
            {
                MessageBox.Show("Enter a value to search for!");
                txtValue.Focus();
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCRUD frm = new frmCRUD();
            this.Close();
            frm.Show();
        }
    }
}
