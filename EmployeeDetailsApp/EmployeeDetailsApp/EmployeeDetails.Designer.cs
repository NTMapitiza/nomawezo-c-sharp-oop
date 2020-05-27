namespace EmployeeDetailsApp
{
    partial class frmEmployeeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label managerIndLabel;
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eTBdbDataSet = new EmployeeDetailsApp.ETBdbDataSet();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new EmployeeDetailsApp.ETBdbDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new EmployeeDetailsApp.ETBdbDataSetTableAdapters.TableAdapterManager();
            this.chkManagerInd = new System.Windows.Forms.CheckBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFirstRow = new System.Windows.Forms.Button();
            this.btnPreviousRow = new System.Windows.Forms.Button();
            this.btnNextRow = new System.Windows.Forms.Button();
            this.btnLastRow = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.etBdbDataSet1 = new EmployeeDetailsApp.ETBdbDataSet();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            managerIndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTBdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etBdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(61, 71);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(103, 17);
            employeeIDLabel.TabIndex = 12;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(61, 99);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(91, 17);
            firstNameLabel.TabIndex = 13;
            firstNameLabel.Text = "First Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            surnameLabel.Location = new System.Drawing.Point(61, 127);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(77, 17);
            surnameLabel.TabIndex = 14;
            surnameLabel.Text = "Surname:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(61, 155);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(97, 17);
            departmentLabel.TabIndex = 15;
            departmentLabel.Text = "Department:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateLabel.Location = new System.Drawing.Point(61, 183);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(87, 17);
            startDateLabel.TabIndex = 16;
            startDateLabel.Text = "Start Date:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaryLabel.Location = new System.Drawing.Point(61, 211);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(59, 17);
            salaryLabel.TabIndex = 17;
            salaryLabel.Text = "Salary:";
            // 
            // managerIndLabel
            // 
            managerIndLabel.AutoSize = true;
            managerIndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            managerIndLabel.Location = new System.Drawing.Point(61, 239);
            managerIndLabel.Name = "managerIndLabel";
            managerIndLabel.Size = new System.Drawing.Size(103, 17);
            managerIndLabel.TabIndex = 18;
            managerIndLabel.Text = "Manager Ind:";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.eTBdbDataSet;
            // 
            // eTBdbDataSet
            // 
            this.eTBdbDataSet.DataSetName = "ETBdbDataSet";
            this.eTBdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeID", true));
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(173, 66);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(186, 23);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(173, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(186, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Surname", true));
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(173, 122);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(186, 23);
            this.txtSurname.TabIndex = 3;
            // 
            // txtStartDate
            // 
            this.txtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "StartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(173, 178);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(186, 23);
            this.txtStartDate.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Salary", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtSalary.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeBindingSource3, "Salary", true));
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(173, 206);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(186, 23);
            this.txtSalary.TabIndex = 6;
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataMember = "Employee";
            this.employeeBindingSource3.DataSource = this.eTBdbDataSet;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.eTBdbDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(461, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(461, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(461, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(461, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeDetailsApp.ETBdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chkManagerInd
            // 
            this.chkManagerInd.AutoSize = true;
            this.chkManagerInd.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeeBindingSource, "ManagerInd", true));
            this.chkManagerInd.Location = new System.Drawing.Point(173, 239);
            this.chkManagerInd.Name = "chkManagerInd";
            this.chkManagerInd.Size = new System.Drawing.Size(18, 17);
            this.chkManagerInd.TabIndex = 7;
            this.chkManagerInd.UseVisualStyleBackColor = true;
            // 
            // txtDepartment
            // 
            this.txtDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Department", true));
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDepartment.Location = new System.Drawing.Point(173, 150);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(186, 23);
            this.txtDepartment.TabIndex = 4;
            this.txtDepartment.TextChanged += new System.EventHandler(this.txtDepartment_TextChanged);
            this.txtDepartment.Enter += new System.EventHandler(this.txtDepartment_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnFirstRow
            // 
            this.btnFirstRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstRow.Location = new System.Drawing.Point(27, 12);
            this.btnFirstRow.Name = "btnFirstRow";
            this.btnFirstRow.Size = new System.Drawing.Size(104, 29);
            this.btnFirstRow.TabIndex = 12;
            this.btnFirstRow.Text = "<< First";
            this.btnFirstRow.UseVisualStyleBackColor = true;
            this.btnFirstRow.Click += new System.EventHandler(this.btnFirstRow_Click);
            // 
            // btnPreviousRow
            // 
            this.btnPreviousRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousRow.Location = new System.Drawing.Point(137, 12);
            this.btnPreviousRow.Name = "btnPreviousRow";
            this.btnPreviousRow.Size = new System.Drawing.Size(111, 29);
            this.btnPreviousRow.TabIndex = 13;
            this.btnPreviousRow.Text = "< Previous";
            this.btnPreviousRow.UseVisualStyleBackColor = true;
            this.btnPreviousRow.Click += new System.EventHandler(this.btnPreviousRow_Click);
            // 
            // btnNextRow
            // 
            this.btnNextRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRow.Location = new System.Drawing.Point(355, 12);
            this.btnNextRow.Name = "btnNextRow";
            this.btnNextRow.Size = new System.Drawing.Size(97, 29);
            this.btnNextRow.TabIndex = 14;
            this.btnNextRow.Text = "Next >";
            this.btnNextRow.UseVisualStyleBackColor = true;
            this.btnNextRow.Click += new System.EventHandler(this.btnNextRow_Click);
            // 
            // btnLastRow
            // 
            this.btnLastRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastRow.Location = new System.Drawing.Point(461, 12);
            this.btnLastRow.Name = "btnLastRow";
            this.btnLastRow.Size = new System.Drawing.Size(98, 29);
            this.btnLastRow.TabIndex = 15;
            this.btnLastRow.Text = "Last >>";
            this.btnLastRow.UseVisualStyleBackColor = true;
            this.btnLastRow.Click += new System.EventHandler(this.btnLastRow_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(254, 12);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(95, 22);
            this.txtPosition.TabIndex = 23;
            this.txtPosition.TabStop = false;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.eTBdbDataSet;
            // 
            // etBdbDataSet1
            // 
            this.etBdbDataSet1.DataSetName = "ETBdbDataSet";
            this.etBdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 319);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnLastRow);
            this.Controls.Add(this.btnNextRow);
            this.Controls.Add(this.btnPreviousRow);
            this.Controls.Add(this.btnFirstRow);
            this.Controls.Add(this.chkManagerInd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(managerIndLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTBdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etBdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ETBdbDataSet eTBdbDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ETBdbDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private ETBdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkManagerInd;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnLastRow;
        private System.Windows.Forms.Button btnNextRow;
        private System.Windows.Forms.Button btnPreviousRow;
        private System.Windows.Forms.Button btnFirstRow;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource employeeBindingSource3;
        private ETBdbDataSet etBdbDataSet1;
    }
}

