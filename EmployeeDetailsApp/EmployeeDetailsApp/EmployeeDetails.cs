using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDetailsApp
{
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.employeeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.eTBdbDataSet);

            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occured. " +
                    "Some rows were not updated.", "Concurrency Exception");
                this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                employeeBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void employeeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occured.\n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");

        }

        private static string connectionString =
            "Data Source=LAPTOP-B2D6CMDK;Initial Catalog=ETBdb;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);

        int employeeID = 0;
        string firstName = "";
        string surname = "";
        string department = "";
        DateTime startDate;
        //decimal salary = 0.0M;
        string salary = "";
        bool managerInd = false;

        private void populateRecord()
        {
                
            employeeID = Convert.ToInt32(txtEmployeeID.Text);
            firstName = txtFirstName.Text;
            surname = txtSurname.Text;
            department = txtDepartment.Text;
            startDate = Convert.ToDateTime(txtStartDate.Text);
            salary = txtSalary.Text;
            //salary = Convert.ToDecimal(txtSalary.Text);
            //NumberFormatInfo LocalFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            //LocalFormat.CurrencySymbol = "£";
            //txtSalary.Text = salary.ToString("C", LocalFormat);

            if (chkManagerInd.Checked)
            {
                managerInd = true;
            }
            else
            {
                managerInd = false;
            }
              
        }     
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            populateRecord();

            string insertStatement = "INSERT INTO Employee" +
                " (EmployeeID, FirstName, Surname, Department, StartDate, Salary, ManagerInd) " +
                " VALUES (@EmployeeID, @FirstName, @Surname, @Department, @StartDate, @Salary, @ManagerInd);";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            insertCommand.Parameters.AddWithValue("@FirstName", firstName);
            insertCommand.Parameters.AddWithValue("@Surname", surname);
            insertCommand.Parameters.AddWithValue("@Department", department);
            insertCommand.Parameters.AddWithValue("@StartDate", startDate);
            insertCommand.Parameters.AddWithValue("@Salary", salary);
            insertCommand.Parameters.AddWithValue("@ManagerInd", managerInd);

            try
            {
                connection.Open();
                int employeeCount = insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Record Inserted", "Information");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            populateRecord();
            
            string updateStatement = "UPDATE Employee SET" +
                " FirstName = @FirstName, Surname = @Surname, Department = @Department," +
                " StartDate = @StartDate, Salary = @Salary, ManagerInd = @ManagerInd" +
                " WHERE EmployeeID = @EmployeeID";
            
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            updateCommand.Parameters.AddWithValue("@FirstName", firstName);
            updateCommand.Parameters.AddWithValue("@Surname", surname);
            updateCommand.Parameters.AddWithValue("@Department", department);
            updateCommand.Parameters.AddWithValue("@StartDate", startDate);
            updateCommand.Parameters.AddWithValue("@Salary", salary);
            updateCommand.Parameters.AddWithValue("@ManagerInd", managerInd);

            try
            {
                connection.Open();
                int employeeCount = updateCommand.ExecuteNonQuery();
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
            employeeID = Convert.ToInt32(txtEmployeeID.Text);
            
            string deleteStatement = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            
            try
            {
                connection.Open();
                int employeeCount = deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Record Deleted", "Information");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string selectStatement = "SELECT TOP 1 * FROM Employee";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@EmployeeID", employeeID);

            connection.Open();
            SqlDataReader empReader =
                selectCommand.ExecuteReader(CommandBehavior.SingleRow);

            if (empReader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeID = (int)empReader["EmployeeID"];
                txtEmployeeID.Text = empReader["EmployeeID"].ToString();
                txtFirstName.Text = empReader["FirstName"].ToString();
                txtSurname.Text = empReader["Surname"].ToString();
                txtDepartment.Text = empReader["Department"].ToString();
                txtStartDate.Text = empReader["StartDate"].ToString();
                txtSalary.Text = empReader["Salary"].ToString();
                chkManagerInd.Text = empReader["ManagerInd"].ToString();

            }
            MessageBox.Show("Record Selected!");

            empReader.Close();

        }

        private const string textPrefix = @"Dept:";
        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            if (!txtDepartment.Text.StartsWith(textPrefix))
            {
                txtDepartment.Text = textPrefix;
                txtDepartment.SelectionStart = txtDepartment.Text.Length;
            }
        }

        private void txtDepartment_Enter(object sender, EventArgs e)
        {
            txtDepartment.SelectionStart = txtDepartment.Text.Length;
        }             
    }
}
