namespace InventoryMaintenanceApp
{
    partial class frmInventoryItem
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
            this.rdoPlant = new System.Windows.Forms.RadioButton();
            this.rdoSupply = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoPlant
            // 
            this.rdoPlant.AutoSize = true;
            this.rdoPlant.Location = new System.Drawing.Point(186, 22);
            this.rdoPlant.Name = "rdoPlant";
            this.rdoPlant.Size = new System.Drawing.Size(61, 21);
            this.rdoPlant.TabIndex = 0;
            this.rdoPlant.TabStop = true;
            this.rdoPlant.Text = "Plant";
            this.rdoPlant.UseVisualStyleBackColor = true;
            // 
            // rdoSupply
            // 
            this.rdoSupply.AutoSize = true;
            this.rdoSupply.Location = new System.Drawing.Point(338, 22);
            this.rdoSupply.Name = "rdoSupply";
            this.rdoSupply.Size = new System.Drawing.Size(72, 21);
            this.rdoSupply.TabIndex = 1;
            this.rdoSupply.TabStop = true;
            this.rdoSupply.Text = "Supply";
            this.rdoSupply.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item no:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manufacturer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(186, 77);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 22);
            this.txtItem.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(186, 123);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(303, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(186, 168);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(121, 24);
            this.cmbManufacturer.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(186, 215);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(356, 267);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 11;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // frmInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 342);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoSupply);
            this.Controls.Add(this.rdoPlant);
            this.Name = "frmInventoryItem";
            this.Text = "New Inventory Item";
            this.Load += new System.EventHandler(this.frmInventoryItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.RadioButton rdoSupply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button txtCancel;
    }
}