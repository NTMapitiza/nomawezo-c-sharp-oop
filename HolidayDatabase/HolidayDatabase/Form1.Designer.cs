namespace HolidayDatabase
{
    partial class frmHoliday
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
            System.Windows.Forms.Label holidayNoLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label departureDateLabel;
            System.Windows.Forms.Label noOfDaysLabel;
            System.Windows.Forms.Label availableLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.travelDBDataSet = new HolidayDatabase.TravelDBDataSet();
            this.tblHolidayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHolidayTableAdapter = new HolidayDatabase.TravelDBDataSetTableAdapters.tblHolidayTableAdapter();
            this.tableAdapterManager = new HolidayDatabase.TravelDBDataSetTableAdapters.TableAdapterManager();
            this.txtHolidayNo = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtNoOfDays = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnLastRow = new System.Windows.Forms.Button();
            this.btnNextRow = new System.Windows.Forms.Button();
            this.btnPreviousRow = new System.Windows.Forms.Button();
            this.btnFirstRow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            holidayNoLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            noOfDaysLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHolidayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(140, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downton Travel";
            // 
            // travelDBDataSet
            // 
            this.travelDBDataSet.DataSetName = "TravelDBDataSet";
            this.travelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHolidayBindingSource
            // 
            this.tblHolidayBindingSource.DataMember = "tblHoliday";
            this.tblHolidayBindingSource.DataSource = this.travelDBDataSet;
            // 
            // tblHolidayTableAdapter
            // 
            this.tblHolidayTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblHolidayTableAdapter = this.tblHolidayTableAdapter;
            this.tableAdapterManager.UpdateOrder = HolidayDatabase.TravelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // holidayNoLabel
            // 
            holidayNoLabel.AutoSize = true;
            holidayNoLabel.Location = new System.Drawing.Point(31, 156);
            holidayNoLabel.Name = "holidayNoLabel";
            holidayNoLabel.Size = new System.Drawing.Size(113, 17);
            holidayNoLabel.TabIndex = 17;
            holidayNoLabel.Text = "Holiday Number:";
            // 
            // txtHolidayNo
            // 
            this.txtHolidayNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "HolidayNo", true));
            this.txtHolidayNo.Location = new System.Drawing.Point(147, 153);
            this.txtHolidayNo.Name = "txtHolidayNo";
            this.txtHolidayNo.Size = new System.Drawing.Size(75, 22);
            this.txtHolidayNo.TabIndex = 0;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new System.Drawing.Point(31, 184);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(83, 17);
            destinationLabel.TabIndex = 18;
            destinationLabel.Text = "Destination:";
            // 
            // txtDestination
            // 
            this.txtDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "Destination", true));
            this.txtDestination.Location = new System.Drawing.Point(147, 181);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(185, 22);
            this.txtDestination.TabIndex = 1;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(31, 212);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(40, 17);
            costLabel.TabIndex = 19;
            costLabel.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "Cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtCost.Location = new System.Drawing.Point(147, 209);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(104, 22);
            this.txtCost.TabIndex = 2;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new System.Drawing.Point(31, 240);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(110, 17);
            departureDateLabel.TabIndex = 20;
            departureDateLabel.Text = "Departure Date:";
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "DepartureDate", true));
            this.txtDepartureDate.Location = new System.Drawing.Point(147, 237);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(104, 22);
            this.txtDepartureDate.TabIndex = 3;
            // 
            // noOfDaysLabel
            // 
            noOfDaysLabel.AutoSize = true;
            noOfDaysLabel.Location = new System.Drawing.Point(31, 268);
            noOfDaysLabel.Name = "noOfDaysLabel";
            noOfDaysLabel.Size = new System.Drawing.Size(85, 17);
            noOfDaysLabel.TabIndex = 21;
            noOfDaysLabel.Text = "No Of Days:";
            // 
            // txtNoOfDays
            // 
            this.txtNoOfDays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "NoOfDays", true));
            this.txtNoOfDays.Location = new System.Drawing.Point(147, 265);
            this.txtNoOfDays.Name = "txtNoOfDays";
            this.txtNoOfDays.Size = new System.Drawing.Size(53, 22);
            this.txtNoOfDays.TabIndex = 4;
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(31, 298);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(69, 17);
            availableLabel.TabIndex = 22;
            availableLabel.Text = "Available:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(459, 134);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 41);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(459, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 41);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(459, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 41);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(459, 257);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 41);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(459, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 41);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(459, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(159, 345);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(93, 27);
            this.txtPosition.TabIndex = 16;
            this.txtPosition.TabStop = false;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLastRow
            // 
            this.btnLastRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastRow.Location = new System.Drawing.Point(328, 339);
            this.btnLastRow.Margin = new System.Windows.Forms.Padding(4);
            this.btnLastRow.Name = "btnLastRow";
            this.btnLastRow.Size = new System.Drawing.Size(80, 41);
            this.btnLastRow.TabIndex = 15;
            this.btnLastRow.Text = ">>";
            this.btnLastRow.UseVisualStyleBackColor = true;
            this.btnLastRow.Click += new System.EventHandler(this.btnLastRow_Click);
            // 
            // btnNextRow
            // 
            this.btnNextRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRow.Location = new System.Drawing.Point(252, 339);
            this.btnNextRow.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextRow.Name = "btnNextRow";
            this.btnNextRow.Size = new System.Drawing.Size(80, 41);
            this.btnNextRow.TabIndex = 14;
            this.btnNextRow.Text = ">";
            this.btnNextRow.UseVisualStyleBackColor = true;
            this.btnNextRow.Click += new System.EventHandler(this.btnNextRow_Click);
            // 
            // btnPreviousRow
            // 
            this.btnPreviousRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousRow.Location = new System.Drawing.Point(81, 339);
            this.btnPreviousRow.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousRow.Name = "btnPreviousRow";
            this.btnPreviousRow.Size = new System.Drawing.Size(80, 41);
            this.btnPreviousRow.TabIndex = 13;
            this.btnPreviousRow.Text = "<";
            this.btnPreviousRow.UseVisualStyleBackColor = true;
            this.btnPreviousRow.Click += new System.EventHandler(this.btnPreviousRow_Click);
            // 
            // btnFirstRow
            // 
            this.btnFirstRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstRow.Location = new System.Drawing.Point(4, 339);
            this.btnFirstRow.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirstRow.Name = "btnFirstRow";
            this.btnFirstRow.Size = new System.Drawing.Size(80, 41);
            this.btnFirstRow.TabIndex = 12;
            this.btnFirstRow.Text = "<<";
            this.btnFirstRow.UseVisualStyleBackColor = true;
            this.btnFirstRow.Click += new System.EventHandler(this.btnFirstRow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HolidayDatabase.Properties.Resources.travel1;
            this.pictureBox1.Location = new System.Drawing.Point(453, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 113);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // chkAvailable
            // 
            this.chkAvailable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblHolidayBindingSource, "Available", true));
            this.chkAvailable.Location = new System.Drawing.Point(147, 293);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(104, 24);
            this.chkAvailable.TabIndex = 5;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // frmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnLastRow);
            this.Controls.Add(this.btnNextRow);
            this.Controls.Add(this.btnPreviousRow);
            this.Controls.Add(this.btnFirstRow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(holidayNoLabel);
            this.Controls.Add(this.txtHolidayNo);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(departureDateLabel);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(noOfDaysLabel);
            this.Controls.Add(this.txtNoOfDays);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmHoliday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task A Nomawezo Mapitiza 22/06/2020";
            this.Load += new System.EventHandler(this.frmHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHolidayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelDBDataSet travelDBDataSet;
        private System.Windows.Forms.BindingSource tblHolidayBindingSource;
        private TravelDBDataSetTableAdapters.tblHolidayTableAdapter tblHolidayTableAdapter;
        private TravelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtHolidayNo;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtNoOfDays;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnLastRow;
        private System.Windows.Forms.Button btnNextRow;
        private System.Windows.Forms.Button btnPreviousRow;
        private System.Windows.Forms.Button btnFirstRow;
        private System.Windows.Forms.CheckBox chkAvailable;
    }
}

