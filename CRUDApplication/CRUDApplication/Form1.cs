using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

namespace CRUDApplication
{
    public partial class frmCRUD : Form
    {
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occured. " +
                    "Some rows were not updated.", "Concurrency Exception");
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                productsBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }
        DateTime currentDateTime = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
                //
                lblDate.Text = currentDateTime.ToLongDateString();

                this.productsBindingSource.MoveFirst();
                int position = productsBindingSource.Position + 1;
                txtPosition.Text = position + " of " + productsBindingSource.Count;
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString()) ;
            }
        }
        private static string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MMABooks.mdf;" +
            "Integrated Security=True;Connect Timeout=30";
        private static SqlConnection connection = new SqlConnection(connectionString);

        string productCode = "";
        string description = "";
        double unitPrice = 0D;
        int onHandQuantity = 0;
        
        private void populateRecord()
        {
            try
            {
                productCode = Convert.ToString(txtProductCode.Text);
                description = txtDescription.Text;
                string priceStr = (txtUnitPrice.Text).Trim();
                string  moneyStr = priceStr.Substring(1);
                unitPrice = Convert.ToDouble(moneyStr);
                onHandQuantity = Convert.ToInt32(txtOnHandQuantity.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            populateRecord();
            if (IsWithinRange())
            {
                string insertStatement = "INSERT INTO Products" +
                " (ProductCode, Description, UnitPrice, OnHandQuantity) " +
                " VALUES (@ProductCode, @Description, @UnitPrice, @OnHandQuantity);";
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@ProductCode", productCode);
                insertCommand.Parameters.AddWithValue("@Description", description);
                insertCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
                insertCommand.Parameters.AddWithValue("@OnHandQuantity", onHandQuantity);

                try
                {
                    connection.Open();
                    int productCount = insertCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error # " + ex.Number +
                        ": " + ex.Message, ex.GetType().ToString());
                }
                finally
                {
                    connection.Close();
                }
                MessageBox.Show("Record Inserted", "Information");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            populateRecord();

            string updateStatement = "UPDATE Products SET" +
                " ProductCode = @ProductCode, Description = @Description," 
                    + " UnitPrice = @UnitPrice, OnHandQuantity = @OnHandQuantity" 
                    + " WHERE ProductCode = @ProductCode";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@ProductCode", productCode);
            updateCommand.Parameters.AddWithValue("@Description", description);
            updateCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
            updateCommand.Parameters.AddWithValue("@OnHandQuantity", onHandQuantity);

            try
            {
                connection.Open();
                int productCount = updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Record Updated", "Information");
        }
                
        private void btnDelete_Click(object sender, EventArgs e)
        {
            productCode = txtProductCode.Text;

            string deleteStatement = "DELETE FROM Products WHERE ProductCode = @ProductCode";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@ProductCode", productCode);

            try
            {
                connection.Open();
                int employeeCount = deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Record Deleted", "Information");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string reportDate = "";
            int lineCount = 1;
            int pageCount = 0;
            reportDate = currentDateTime.ToString("dd/MM/yyyy");
            using (StreamWriter sr = new StreamWriter(@"C:\ProductsFile\ProductsOutput.txt"))
            {
                if (lineCount > 23)
                {
                    pageCount++;
                }
                else
                {
                    sr.WriteLine($"\t\t\t\t\t" + "Products Details" + "\t\t\t\t" + "Page: " + lineCount);
                    sr.WriteLine($"\t\t\t\t\t" + reportDate + "\t\t\t\t");
                    sr.WriteLine();
                    sr.WriteLine($"ProductCode" + "\t\t"
                    + "Description" + "\t\t" + "UnitPrice" + "\t\t" + "OnHandQuantity");
                    
                    lineCount += 3;
                }
            }
            
            //string filePath = @"C:\ProductsFile\Products.txt";
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //File.WriteAllText(@"C:\ProductsFile\ProductsOutput.txt", $"ProductCode" + "\t\t" 
            //    + "Description" + "\t\t" + "UnitPrice" +"\t\t" + "OnHandQuantity");
            //foreach (string line in lines)
            //{
            //    MessageBox.Show(line);
            //}
            //lines.Add("NTM20, Biology, 55.99, 6320");
            //File.WriteAllLines(@"C:\ProductsFile\Products.txt", lines);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForm frm = new frmSearchForm();

            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveFirst();
            int position = productsBindingSource.Position + 1;
            txtPosition.Text = position + " of " +  productsBindingSource.Count;

            MessageBox.Show("Changes Made To Record Cleared!");
            
        }

        private void btnPreviousRow_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MovePrevious();
            int position = productsBindingSource.Position + 1;
            txtPosition.Text = position + " of " + productsBindingSource.Count;
        }

        private void btnNextRow_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveNext();
            int position = productsBindingSource.Position + 1;
            txtPosition.Text = position + " of " + productsBindingSource.Count;
        }

        private void btnLastRow_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveLast();
            int position = productsBindingSource.Position + 1;
            txtPosition.Text = position + " of " + productsBindingSource.Count;
        }

        private void btnFirstRow_Click_1(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveFirst();
            int position = productsBindingSource.Position + 1;
            txtPosition.Text = position + " of " + productsBindingSource.Count;
        }

        public bool IsWithinRange()
        {
            int employeeNumber = Convert.ToInt32(txtProductCode.Text);
            if (employeeNumber <= 0 || employeeNumber > 20000)
            {
                MessageBox.Show("Employee ID must be between 00001 and 20000", "Error Entry");
                txtProductCode.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
