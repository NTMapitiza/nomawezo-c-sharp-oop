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
        int employeeID;
        string firstName;
        string surname;
        string dept;
        string startDate;
        decimal salary;
        bool managerInd;
        private SqlConnection connection;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            employeeID = Convert.ToInt32(txtEmployeeID.Text);
            firstName = txtFirstName.Text;
            surname = txtSurname.Text;
            dept = txtDept.Text;
            startDate = txtStartDate.Text;
            salary = Convert.ToDecimal(txtSalary.Text);
            managerInd = Convert.ToBoolean(txtManagerInd.Text);

            this.employeeTableAdapter.InsertQuery(employeeID, firstName, surname, dept, startDate, salary, managerInd);
            MessageBox.Show("Record inserted", "Information");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateStatement = "UPDATE Employee table" +
                " (EmployeeID,FirstName,LastName,Department,StartDate, Salary, ManagerInd) " +
                " VALUES (@EmployeeID, @FirstName, @LastName, @Department, @StartDate, @Salary, @ManagerInd)";
            SqlCommand insertCommand = new SqlCommand(updateStatement, connection);
            insertCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            insertCommand.Parameters.AddWithValue("@FirstName", firstName);
            insertCommand.Parameters.AddWithValue("@LastName", surname);
            insertCommand.Parameters.AddWithValue("@Department", dept);
            insertCommand.Parameters.AddWithValue("@StartDate", startDate);
            insertCommand.Parameters.AddWithValue("@Salary", salary);
            insertCommand.Parameters.AddWithValue("@ManagerInd", managerInd);

            MessageBox.Show("Record Updated", "Information");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteStatement = "DELETE Employee record" +
                "WHERE (EmployeeID = @EmployeeID)";
                SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
                deleteCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                deleteCommand.Parameters.AddWithValue("@FirstName", firstName);
                deleteCommand.Parameters.AddWithValue("@LastName", surname);
                deleteCommand.Parameters.AddWithValue("@Department", dept);
                deleteCommand.Parameters.AddWithValue("@StartDate", startDate);
                deleteCommand.Parameters.AddWithValue("@Salary", salary);
                deleteCommand.Parameters.AddWithValue("@ManagerInd", managerInd);

                MessageBox.Show("Record Deleted", "Information");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete", ex.Message);
            }
           
        }
    }
}
