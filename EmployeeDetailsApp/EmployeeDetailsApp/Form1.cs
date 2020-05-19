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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTBdbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.eTBdbDataSet.Employee);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(txtEmpID.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtSurname.Text;
            string dept = txtDepartment.Text;
            string startDate = txtStartDate.Text;
            decimal salary = Convert.ToDecimal(txtSalary.Text);
            bool managerInd = false;

            this.employeeTableAdapter.AddQuery(employeeId, firstName, lastName, dept, startDate, salary, managerInd);
            MessageBox.Show("Record added to Employee table");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.employeeTableAdapter.UpdateQuery();
            //}
            //catch (SqlException ex)
            //{

            //    throw;
            //}
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
