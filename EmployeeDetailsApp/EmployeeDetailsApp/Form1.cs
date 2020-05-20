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

namespace EmployeeDetailsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'eTBdbDataSet.Employee' table. You can move, or remove it, as needed.
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
        
        int employeeID;
        string firstName;
        string surname;
        string department;
        string startDate;
        decimal salary;
        bool managerInd;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            employeeID = Convert.ToInt32(txtEmployeeID.Text);
            firstName = txtFirstName.Text;
            surname = txtSurname.Text;
            department = txtDept.Text;
            startDate = txtStartDate.Text;
            salary = Convert.ToDecimal(txtSalary.Text);
            managerInd = Convert.ToBoolean(txtManagerInd.Text);

            this.employeeTableAdapter.InsertQuery(employeeID, firstName, surname, department, startDate, salary, managerInd);
            MessageBox.Show("Record inserted", "Information");

            //string insertStatement = "INSERT INTO Employee" +
            //    " (EmployeeID, FirstName, Surname, Department, StartDate, Salary, ManagerInd) " +
            //    " VALUES (@EmployeeID, @FirstName, @Surname, @Department, @StartDate, @Salary, @ManagerInd)";
            //SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            //insertCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            //insertCommand.Parameters.AddWithValue("@FirstName", firstName);
            //insertCommand.Parameters.AddWithValue("@Surname", surname);
            //insertCommand.Parameters.AddWithValue("@Department", department);
            //insertCommand.Parameters.AddWithValue("@StartDate", startDate);
            //insertCommand.Parameters.AddWithValue("@Salary", salary);
            //insertCommand.Parameters.AddWithValue("@ManagerInd", managerInd);

            //try
            //{
            //    connection.Open();
            //    int empCount = insertCommand.ExecuteNonQuery();
            //}
            //catch (SqlException ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateStatement = "UPDATE Employee SET" +
                " (EmployeeID = @EmployeeID, FirstName = @FirstName, Surname = @Surname," +
                " Department = @Department, StartDate = @StartDate, Salary = @Salary," +
                " ManagerInd = @ManagerInd)" +
                " WHERE (EmployeeID = @Original_EmployeeID) AND (FirstName = @Original_FirstName)" +
                        " AND (Surname = @Original_Surname) AND (Department = @Original_Department)" +
                        " AND (StartDate = @Original_StartDate) AND (Salary = @Original_Salary)" +
                        " AND (ManagerInd = @Original_ManagerInd);" +
                "SELECT EmployeeID, FirstName, Surname, Department, StartDate, Salary, ManagerInd FROM Employee WHERE(EmployeeID = @EmployeeID);";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            updateCommand.Parameters.AddWithValue("@FirstName", firstName);
            updateCommand.Parameters.AddWithValue("@Surname", surname);
            updateCommand.Parameters.AddWithValue("@Department", department);
            updateCommand.Parameters.AddWithValue("@StartDate", startDate);
            updateCommand.Parameters.AddWithValue("@Salary", salary);
            updateCommand.Parameters.AddWithValue("@Manager", managerInd);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteStatement = "DELETE FROM Employee WHERE EmployeeID = @OriginalI_EmployeeID);";
                
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string selectStatement = "SELECT EmployeeID, FirstName, LastName, Department, StartDate, Salary, ManagerInd " +
                "FROM Employee WHERE EmployeeID = @EmployeeID;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            
            connection.Open();
            SqlDataReader empReader =
                selectCommand.ExecuteReader(CommandBehavior.SingleRow);

            if (empReader.Read())
            {
                Employee employee = new EmployeeDetailsApp.Employee();
                employee.EmployeeID = (int)empReader["EmployeeID"];
                txtEmployeeID.Text = empReader["EmployeeID"].ToString();
                txtFirstName.Text = empReader["FirstName"].ToString();
                txtSurname.Text = empReader["Surname"].ToString();
                txtDept.Text = empReader["Department"].ToString();
                txtStartDate.Text = empReader["StartDate"].ToString();
                txtSalary.Text = empReader["Salary"].ToString();
                txtManagerInd.Text = empReader["ManagerInd"].ToString();
                //return employee;
            }

            empReader.Close();

        }
    }
}
