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
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eTBdbDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eTBdbDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eTBdbDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eTBdbDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eTBdbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTBdbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string insertStatement = "INSERT INTO tblEmployee" +
            //    " (EmployeeID,FirstName,LastName,Department,StartDate, Salary, ManagerInd) " +
            //    " VALUES (@txtEmpID, @txtFirstName, @txtSurname, @txtDepartment, @txtStartDate, @txtSalary, @txtManagerInd)";
            //SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            //insertCommand.Parameters.AddWithValue("@txtEmpID", empID);
            //insertCommand.Parameters.AddWithValue("@FirstName", empFirstName);
            //insertCommand.Parameters.AddWithValue("@Surname", empSurname);
            //insertCommand.Parameters.AddWithValue("@Dept", empDept);
            //insertCommand.Parameters.AddWithValue("@StartDate", empStartDate);
            //insertCommand.Parameters.AddWithValue("@Salary", empSalary);
            //insertCommand.Parameters.AddWithValue("@Manager", mgrInd);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
