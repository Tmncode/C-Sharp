namespace Individual_Payroll_summary
{
    partial class formPayroll
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
            this.enterName = new System.Windows.Forms.Label();
            this.ssnNumber = new System.Windows.Forms.Label();
            this.hourlyPayRate = new System.Windows.Forms.Label();
            this.hourWorked = new System.Windows.Forms.Label();
            this.netPay = new System.Windows.Forms.Label();
            this.federalTaxDeduction = new System.Windows.Forms.Label();
            this.stateTaxDeduction = new System.Windows.Forms.Label();
            this.grossPay = new System.Windows.Forms.Label();
            this.butComplete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtHourWork = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.txtFedTax = new System.Windows.Forms.TextBox();
            this.txtStateTax = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterName.Location = new System.Drawing.Point(13, 13);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(73, 13);
            this.enterName.TabIndex = 0;
            this.enterName.Text = "Enter Name";
            // 
            // ssnNumber
            // 
            this.ssnNumber.AutoSize = true;
            this.ssnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnNumber.Location = new System.Drawing.Point(12, 38);
            this.ssnNumber.Name = "ssnNumber";
            this.ssnNumber.Size = new System.Drawing.Size(173, 13);
            this.ssnNumber.TabIndex = 1;
            this.ssnNumber.Text = "Enter Social Security Number";
            // 
            // hourlyPayRate
            // 
            this.hourlyPayRate.AutoSize = true;
            this.hourlyPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayRate.Location = new System.Drawing.Point(12, 61);
            this.hourlyPayRate.Name = "hourlyPayRate";
            this.hourlyPayRate.Size = new System.Drawing.Size(99, 13);
            this.hourlyPayRate.TabIndex = 2;
            this.hourlyPayRate.Text = "Hourly Pay Rate";
            // 
            // hourWorked
            // 
            this.hourWorked.AutoSize = true;
            this.hourWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourWorked.Location = new System.Drawing.Point(13, 83);
            this.hourWorked.Name = "hourWorked";
            this.hourWorked.Size = new System.Drawing.Size(82, 13);
            this.hourWorked.TabIndex = 3;
            this.hourWorked.Text = "Hour Worked";
            // 
            // netPay
            // 
            this.netPay.AutoSize = true;
            this.netPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPay.Location = new System.Drawing.Point(149, 233);
            this.netPay.Name = "netPay";
            this.netPay.Size = new System.Drawing.Size(52, 13);
            this.netPay.TabIndex = 4;
            this.netPay.Text = "Net Pay";
            // 
            // federalTaxDeduction
            // 
            this.federalTaxDeduction.AutoSize = true;
            this.federalTaxDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.federalTaxDeduction.Location = new System.Drawing.Point(149, 180);
            this.federalTaxDeduction.Name = "federalTaxDeduction";
            this.federalTaxDeduction.Size = new System.Drawing.Size(171, 26);
            this.federalTaxDeduction.TabIndex = 5;
            this.federalTaxDeduction.Text = "Federal Tax Deduction .15 %\r\n\r\n";
            // 
            // stateTaxDeduction
            // 
            this.stateTaxDeduction.AutoSize = true;
            this.stateTaxDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTaxDeduction.Location = new System.Drawing.Point(149, 207);
            this.stateTaxDeduction.Name = "stateTaxDeduction";
            this.stateTaxDeduction.Size = new System.Drawing.Size(159, 13);
            this.stateTaxDeduction.TabIndex = 6;
            this.stateTaxDeduction.Text = "State Tax Deduction .05 %";
            // 
            // grossPay
            // 
            this.grossPay.AutoSize = true;
            this.grossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPay.Location = new System.Drawing.Point(149, 153);
            this.grossPay.Name = "grossPay";
            this.grossPay.Size = new System.Drawing.Size(64, 13);
            this.grossPay.TabIndex = 7;
            this.grossPay.Text = "Gross Pay";
            // 
            // butComplete
            // 
            this.butComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butComplete.Location = new System.Drawing.Point(433, 379);
            this.butComplete.Name = "butComplete";
            this.butComplete.Size = new System.Drawing.Size(122, 39);
            this.butComplete.TabIndex = 8;
            this.butComplete.Text = "Click Complete";
            this.butComplete.UseVisualStyleBackColor = true;
            this.butComplete.Click += new System.EventHandler(this.butComplete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(195, 30);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 10;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(195, 54);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtPayRate.TabIndex = 11;
            // 
            // txtHourWork
            // 
            this.txtHourWork.Location = new System.Drawing.Point(195, 76);
            this.txtHourWork.Name = "txtHourWork";
            this.txtHourWork.Size = new System.Drawing.Size(100, 20);
            this.txtHourWork.TabIndex = 12;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(325, 146);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(100, 20);
            this.txtNetPay.TabIndex = 13;
            // 
            // txtFedTax
            // 
            this.txtFedTax.Location = new System.Drawing.Point(325, 172);
            this.txtFedTax.Name = "txtFedTax";
            this.txtFedTax.Size = new System.Drawing.Size(100, 20);
            this.txtFedTax.TabIndex = 14;
            // 
            // txtStateTax
            // 
            this.txtStateTax.Location = new System.Drawing.Point(325, 199);
            this.txtStateTax.Name = "txtStateTax";
            this.txtStateTax.Size = new System.Drawing.Size(100, 20);
            this.txtStateTax.TabIndex = 15;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(325, 226);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(100, 20);
            this.txtGrossPay.TabIndex = 16;
            // 
            // formPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.txtStateTax);
            this.Controls.Add(this.txtFedTax);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.txtHourWork);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.butComplete);
            this.Controls.Add(this.grossPay);
            this.Controls.Add(this.stateTaxDeduction);
            this.Controls.Add(this.federalTaxDeduction);
            this.Controls.Add(this.netPay);
            this.Controls.Add(this.hourWorked);
            this.Controls.Add(this.hourlyPayRate);
            this.Controls.Add(this.ssnNumber);
            this.Controls.Add(this.enterName);
            this.Name = "formPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employee Payroll summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.Label ssnNumber;
        private System.Windows.Forms.Label hourlyPayRate;
        private System.Windows.Forms.Label hourWorked;
        private System.Windows.Forms.Label netPay;
        private System.Windows.Forms.Label federalTaxDeduction;
        private System.Windows.Forms.Label stateTaxDeduction;
        private System.Windows.Forms.Label grossPay;
        private System.Windows.Forms.Button butComplete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtHourWork;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.TextBox txtFedTax;
        private System.Windows.Forms.TextBox txtStateTax;
        private System.Windows.Forms.TextBox txtGrossPay;
    }
}

