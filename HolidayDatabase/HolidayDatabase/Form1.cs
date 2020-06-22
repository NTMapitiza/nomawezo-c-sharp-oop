using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data.Common;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using static System.Net.WebRequestMethods;

namespace HolidayDatabase
{
    public partial class frmHoliday : Form
    {
        public frmHoliday()
        {
            InitializeComponent();
        }

        private static string connectionString =
            "Data Source=LAPTOP-B2D6CMDK;Initial Catalog=TravelDB;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);
        
        private void tblHolidayBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblHolidayBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.travelDBDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " +
                    "Some rows were not updated.", "Concurrency Exception");
                this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                tblHolidayBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }

        }
        DateTime currentDateTime = DateTime.Now;
        private void frmHoliday_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }


            this.tblHolidayBindingSource.MoveFirst();
            int position = tblHolidayBindingSource.Position + 1;
            txtPosition.Text = position + " of " + tblHolidayBindingSource.Count;
        }

        private void btnFirstRow_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MoveFirst();
            int position = tblHolidayBindingSource.Position + 1;
            txtPosition.Text = position + " of " + tblHolidayBindingSource.Count;
        }

        private void btnPreviousRow_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MovePrevious();
            int position = tblHolidayBindingSource.Position + 1;
            txtPosition.Text = position + " of " + tblHolidayBindingSource.Count;
        }

        private void btnNextRow_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MoveNext();
            int position = tblHolidayBindingSource.Position + 1;
            txtPosition.Text = position + " of " + tblHolidayBindingSource.Count;
        }

        private void btnLastRow_Click(object sender, EventArgs e)
        {
            this.tblHolidayBindingSource.MoveLast();
            int position = tblHolidayBindingSource.Position + 1;
            txtPosition.Text = position + " of " + tblHolidayBindingSource.Count;
        }

        int holidayNo = 0;
        string destination = "";
        decimal cost = 0m;
        DateTime departureDate;
        int noOfDays = 0;
        bool available = false;
        private void populateRecord()
        {
            try
            {
                String str = (txtCost.Text).Substring(1);

                holidayNo = Convert.ToInt32(txtHolidayNo.Text);
                destination = txtDestination.Text;
                cost = Convert.ToDecimal(str);
                departureDate = Convert.ToDateTime(txtDepartureDate.Text);
                noOfDays = Convert.ToInt32(txtNoOfDays.Text);

                if (chkAvailable.Checked)
                {
                    available = true;
                }
                else
                {
                    available = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please ");
            } 
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            populateRecord();

            string updateStatement = "UPDATE tblHoliday SET" +
                " HolidayNo = @HolidayNo, Destination = @Destination,"
                    + " Cost = @Cost, DepartureDate = @DepartureDate, NoOfDays = @NoOfDays, Available = @Available"
                    + " WHERE HolidayNo = @HolidayNo";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@HolidayNo", holidayNo);
            updateCommand.Parameters.AddWithValue("@Destination", destination);
            updateCommand.Parameters.AddWithValue("@Cost", cost);
            updateCommand.Parameters.AddWithValue("@DepartureDate", departureDate);
            updateCommand.Parameters.AddWithValue("@NoOfDays", noOfDays);
            updateCommand.Parameters.AddWithValue("@Available", available);

            try
            {
                connection.Open();
                int holidayCount = updateCommand.ExecuteNonQuery();
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
            MessageBox.Show("Record Updated", "Information");
        }

        public bool IsWithinRange()
        {
            int holidayNo = Convert.ToInt32(txtHolidayNo.Text);
            if (holidayNo < 200 || holidayNo > 1000)
            {
                MessageBox.Show("1: Holiday number must be in range 200 to 1000.", "Error Entry");
                txtHolidayNo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            populateRecord();
            if (IsWithinRange())
            {
                string insertStatement = "INSERT INTO tblHoliday" +
                " (HolidayNo, Destination, Cost, DepartureDate, NoOfDays, Available) " +
                " VALUES (@HolidayNo, @Destination, @Cost, @DepartureDate, @NoOfDays, @Available);";

                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@HolidayNo", holidayNo);
                insertCommand.Parameters.AddWithValue("@Destination", destination);
                insertCommand.Parameters.AddWithValue("@Cost", cost);
                insertCommand.Parameters.AddWithValue("@DepartureDate", departureDate);
                insertCommand.Parameters.AddWithValue("@NoOfDays", noOfDays);
                insertCommand.Parameters.AddWithValue("@Available", available);

                try
                {
                    connection.Open();
                    int holidayCount = insertCommand.ExecuteNonQuery();
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
                //MessageBox.Show("Record Inserted", "Information");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            holidayNo = Convert.ToInt32(txtHolidayNo.Text);

            string deleteStatement = "DELETE FROM tblHoliday WHERE HolidayNo = @HolidayNo";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@HolidayNo", holidayNo);

            try
            {
                connection.Open();
                int holidayCount = deleteCommand.ExecuteNonQuery();
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int pageNo = 1;
            int lineCount = 0;
            string filePath = @"C:\Users\nomaw\source\repos\nomawezo-c-sharp-oop\C# OOP Assessment\HolidayFile.txt";
            string reportDate = currentDateTime.ToShortDateString();
            string[] mainHeadings = {$"\t\t\t Downton Travel \t\t\t Page {pageNo}",
                                 $"\t\t\t  Date {reportDate}",
                                 $"\n",
                                 $"Holiday No  Destination            Departure Date       Cost  Available \n"};

            //string line = "";

            System.IO.File.WriteAllLines(filePath, mainHeadings);

            string selectStatement = "SELECT * FROM tblHoliday";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            connection.Open();

            SqlDataReader holidayReader = selectCommand.ExecuteReader();

            while (holidayReader.Read())
            {
                int holidayNo = Convert.ToInt32(holidayReader[0]);
                string destination = Convert.ToString(holidayReader[1]);
                decimal cost = Math.Round(Convert.ToDecimal(holidayReader[2]), 2);
                string departureDate = holidayReader.GetDateTime(3).ToShortDateString();
                int noOfDays = Convert.ToInt32(holidayReader[4]);
                string available = Convert.ToString(holidayReader[5]);

                if (lineCount >= 50)
                {
                    pageNo++;
                    string[] headingLines = {$"\t\t\t Downton Travel \t\t\t Page {pageNo}",
                                 $"\t\t\t  Date {reportDate}",
                                 $"\n",
                                 $"Holiday No  Destination            Departure Date       Cost  Available \n"};
                    System.IO.File.AppendAllLines(filePath, headingLines);
                    lineCount = 0;
                }
                string line = "";
                //string availableCheck = "";
                //if (chkAvailable.Checked)
                //{
                //    availableCheck = "Yes";
                //}
                //else
                //{
                //    availableCheck = "No";
                //}
                line = $"{holidayNo} \t    {destination} \t\t   {departureDate} \t     £{cost}  {available} \n";

                System.IO.File.AppendAllText(filePath, line);
                lineCount++;
            }

            holidayReader.Close();
            connection.Close();
            this.tblHolidayTableAdapter.Fill(this.travelDBDataSet.tblHoliday);
        }
    }
}
