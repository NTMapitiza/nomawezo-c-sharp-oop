namespace MyDrive
{
    partial class frmEstimate
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.grpFoundations = new System.Windows.Forms.GroupBox();
            this.rdoBrick = new System.Windows.Forms.RadioButton();
            this.rdoConcrete = new System.Windows.Forms.RadioButton();
            this.rdoTarmac = new System.Windows.Forms.RadioButton();
            this.rdoGravel = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoExtraDeep = new System.Windows.Forms.RadioButton();
            this.lblFromPoundRate = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.lblToEuroRate = new System.Windows.Forms.Label();
            this.lblPerSquareMetre = new System.Windows.Forms.Label();
            this.txtBrickPrice = new System.Windows.Forms.TextBox();
            this.txtConcretePrice = new System.Windows.Forms.TextBox();
            this.txtTarmacPrice = new System.Windows.Forms.TextBox();
            this.txtGravelPrice = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLengthMetres = new System.Windows.Forms.Label();
            this.lblWidthMetres = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.lblEuros = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpType.SuspendLayout();
            this.grpFoundations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Red;
            this.lblFormTitle.Location = new System.Drawing.Point(242, 32);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(286, 35);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Euro Drives or Patios";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdoGravel);
            this.grpType.Controls.Add(this.rdoTarmac);
            this.grpType.Controls.Add(this.rdoConcrete);
            this.grpType.Controls.Add(this.rdoBrick);
            this.grpType.Location = new System.Drawing.Point(24, 141);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(200, 131);
            this.grpType.TabIndex = 1;
            this.grpType.TabStop = false;
            this.grpType.Text = "Materials";
            // 
            // grpFoundations
            // 
            this.grpFoundations.Controls.Add(this.rdoExtraDeep);
            this.grpFoundations.Controls.Add(this.rdoStandard);
            this.grpFoundations.Location = new System.Drawing.Point(470, 141);
            this.grpFoundations.Name = "grpFoundations";
            this.grpFoundations.Size = new System.Drawing.Size(200, 129);
            this.grpFoundations.TabIndex = 2;
            this.grpFoundations.TabStop = false;
            this.grpFoundations.Text = "Foundations";
            // 
            // rdoBrick
            // 
            this.rdoBrick.AutoSize = true;
            this.rdoBrick.Checked = true;
            this.rdoBrick.Location = new System.Drawing.Point(32, 20);
            this.rdoBrick.Name = "rdoBrick";
            this.rdoBrick.Size = new System.Drawing.Size(69, 21);
            this.rdoBrick.TabIndex = 0;
            this.rdoBrick.TabStop = true;
            this.rdoBrick.Text = "BRICK";
            this.rdoBrick.UseVisualStyleBackColor = true;
            // 
            // rdoConcrete
            // 
            this.rdoConcrete.AutoSize = true;
            this.rdoConcrete.Location = new System.Drawing.Point(32, 48);
            this.rdoConcrete.Name = "rdoConcrete";
            this.rdoConcrete.Size = new System.Drawing.Size(105, 21);
            this.rdoConcrete.TabIndex = 1;
            this.rdoConcrete.Text = "CONCRETE";
            this.rdoConcrete.UseVisualStyleBackColor = true;
            // 
            // rdoTarmac
            // 
            this.rdoTarmac.AutoSize = true;
            this.rdoTarmac.Location = new System.Drawing.Point(32, 76);
            this.rdoTarmac.Name = "rdoTarmac";
            this.rdoTarmac.Size = new System.Drawing.Size(86, 21);
            this.rdoTarmac.TabIndex = 2;
            this.rdoTarmac.Text = "TARMAC";
            this.rdoTarmac.UseVisualStyleBackColor = true;
            // 
            // rdoGravel
            // 
            this.rdoGravel.AutoSize = true;
            this.rdoGravel.Location = new System.Drawing.Point(32, 104);
            this.rdoGravel.Name = "rdoGravel";
            this.rdoGravel.Size = new System.Drawing.Size(85, 21);
            this.rdoGravel.TabIndex = 3;
            this.rdoGravel.Text = "GRAVEL";
            this.rdoGravel.UseVisualStyleBackColor = true;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Checked = true;
            this.rdoStandard.Location = new System.Drawing.Point(37, 36);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(105, 21);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "STANDARD";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoExtraDeep
            // 
            this.rdoExtraDeep.AutoSize = true;
            this.rdoExtraDeep.Location = new System.Drawing.Point(37, 73);
            this.rdoExtraDeep.Name = "rdoExtraDeep";
            this.rdoExtraDeep.Size = new System.Drawing.Size(116, 21);
            this.rdoExtraDeep.TabIndex = 1;
            this.rdoExtraDeep.Text = "EXTRA DEEP";
            this.rdoExtraDeep.UseVisualStyleBackColor = true;
            // 
            // lblFromPoundRate
            // 
            this.lblFromPoundRate.AutoSize = true;
            this.lblFromPoundRate.Location = new System.Drawing.Point(53, 85);
            this.lblFromPoundRate.Name = "lblFromPoundRate";
            this.lblFromPoundRate.Size = new System.Drawing.Size(161, 17);
            this.lblFromPoundRate.TabIndex = 3;
            this.lblFromPoundRate.Text = "EXCHANGE RATE: £1 =";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(230, 80);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(100, 22);
            this.txtExchangeRate.TabIndex = 4;
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblToEuroRate
            // 
            this.lblToEuroRate.AutoSize = true;
            this.lblToEuroRate.Location = new System.Drawing.Point(347, 84);
            this.lblToEuroRate.Name = "lblToEuroRate";
            this.lblToEuroRate.Size = new System.Drawing.Size(57, 17);
            this.lblToEuroRate.TabIndex = 5;
            this.lblToEuroRate.Text = "EUROS";
            // 
            // lblPerSquareMetre
            // 
            this.lblPerSquareMetre.AutoSize = true;
            this.lblPerSquareMetre.Location = new System.Drawing.Point(253, 141);
            this.lblPerSquareMetre.Name = "lblPerSquareMetre";
            this.lblPerSquareMetre.Size = new System.Drawing.Size(194, 17);
            this.lblPerSquareMetre.TabIndex = 6;
            this.lblPerSquareMetre.Text = "PRICE PER SQUARE METRE";
            // 
            // txtBrickPrice
            // 
            this.txtBrickPrice.Location = new System.Drawing.Point(278, 162);
            this.txtBrickPrice.Name = "txtBrickPrice";
            this.txtBrickPrice.Size = new System.Drawing.Size(100, 22);
            this.txtBrickPrice.TabIndex = 7;
            this.txtBrickPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConcretePrice
            // 
            this.txtConcretePrice.Location = new System.Drawing.Point(278, 191);
            this.txtConcretePrice.Name = "txtConcretePrice";
            this.txtConcretePrice.Size = new System.Drawing.Size(100, 22);
            this.txtConcretePrice.TabIndex = 8;
            this.txtConcretePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTarmacPrice
            // 
            this.txtTarmacPrice.Location = new System.Drawing.Point(278, 220);
            this.txtTarmacPrice.Name = "txtTarmacPrice";
            this.txtTarmacPrice.Size = new System.Drawing.Size(100, 22);
            this.txtTarmacPrice.TabIndex = 9;
            this.txtTarmacPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGravelPrice
            // 
            this.txtGravelPrice.Location = new System.Drawing.Point(278, 250);
            this.txtGravelPrice.Name = "txtGravelPrice";
            this.txtGravelPrice.Size = new System.Drawing.Size(100, 22);
            this.txtGravelPrice.TabIndex = 10;
            this.txtGravelPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(319, 457);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 11;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(230, 319);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(65, 17);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "LENGTH";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(233, 354);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(53, 17);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.Text = "WIDTH";
            // 
            // lblLengthMetres
            // 
            this.lblLengthMetres.AutoSize = true;
            this.lblLengthMetres.Location = new System.Drawing.Point(421, 319);
            this.lblLengthMetres.Name = "lblLengthMetres";
            this.lblLengthMetres.Size = new System.Drawing.Size(65, 17);
            this.lblLengthMetres.TabIndex = 14;
            this.lblLengthMetres.Text = "METRES";
            // 
            // lblWidthMetres
            // 
            this.lblWidthMetres.AutoSize = true;
            this.lblWidthMetres.Location = new System.Drawing.Point(421, 354);
            this.lblWidthMetres.Name = "lblWidthMetres";
            this.lblWidthMetres.Size = new System.Drawing.Size(65, 17);
            this.lblWidthMetres.TabIndex = 15;
            this.lblWidthMetres.Text = "METRES";
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(158, 387);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(38, 17);
            this.lblPounds.TabIndex = 16;
            this.lblPounds.Text = "GRP";
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.Location = new System.Drawing.Point(367, 387);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(48, 17);
            this.lblEuros.TabIndex = 17;
            this.lblEuros.Text = "EURO";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(141, 456);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(104, 23);
            this.cmdCalculate.TabIndex = 18;
            this.cmdCalculate.Text = "CALCULATE";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(470, 460);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 19;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(297, 312);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 20;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(297, 348);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 21;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(219, 381);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(100, 22);
            this.txtPounds.TabIndex = 22;
            this.txtPounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEuros
            // 
            this.txtEuros.Location = new System.Drawing.Point(428, 382);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(100, 22);
            this.txtEuros.TabIndex = 23;
            this.txtEuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 30);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOutput.Location = new System.Drawing.Point(182, 419);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(346, 23);
            this.lblOutput.TabIndex = 25;
            this.lblOutput.Text = "Brick selected with Standard foundation";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 517);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtEuros);
            this.Controls.Add(this.txtPounds);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.lblEuros);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.lblWidthMetres);
            this.Controls.Add(this.lblLengthMetres);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtGravelPrice);
            this.Controls.Add(this.txtTarmacPrice);
            this.Controls.Add(this.txtConcretePrice);
            this.Controls.Add(this.txtBrickPrice);
            this.Controls.Add(this.lblPerSquareMetre);
            this.Controls.Add(this.lblToEuroRate);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.lblFromPoundRate);
            this.Controls.Add(this.grpFoundations);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Estimates";
            this.Load += new System.EventHandler(this.frmEstimate_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpFoundations.ResumeLayout(false);
            this.grpFoundations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rdoGravel;
        private System.Windows.Forms.RadioButton rdoTarmac;
        private System.Windows.Forms.RadioButton rdoConcrete;
        private System.Windows.Forms.RadioButton rdoBrick;
        private System.Windows.Forms.GroupBox grpFoundations;
        private System.Windows.Forms.RadioButton rdoExtraDeep;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.Label lblFromPoundRate;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label lblToEuroRate;
        private System.Windows.Forms.Label lblPerSquareMetre;
        private System.Windows.Forms.TextBox txtBrickPrice;
        private System.Windows.Forms.TextBox txtConcretePrice;
        private System.Windows.Forms.TextBox txtTarmacPrice;
        private System.Windows.Forms.TextBox txtGravelPrice;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLengthMetres;
        private System.Windows.Forms.Label lblWidthMetres;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblOutput;
    }
}

