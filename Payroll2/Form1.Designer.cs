namespace Payroll2
{
    partial class Form1
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
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.payRateLabel = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.grossPay = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.fedTax = new System.Windows.Forms.Label();
            this.txtFederalTax = new System.Windows.Forms.TextBox();
            this.stateTax = new System.Windows.Forms.Label();
            this.txtStateTax = new System.Windows.Forms.TextBox();
            this.netTotal = new System.Windows.Forms.Label();
            this.genarateButton = new System.Windows.Forms.Button();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.totalResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(212, 119);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 24;
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLabel.Location = new System.Drawing.Point(2, 124);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(101, 15);
            this.hoursWorkedLabel.TabIndex = 23;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyPayRate.Location = new System.Drawing.Point(212, 87);
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyPayRate.TabIndex = 22;
            // 
            // payRateLabel
            // 
            this.payRateLabel.AutoSize = true;
            this.payRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRateLabel.Location = new System.Drawing.Point(2, 92);
            this.payRateLabel.Name = "payRateLabel";
            this.payRateLabel.Size = new System.Drawing.Size(107, 15);
            this.payRateLabel.TabIndex = 21;
            this.payRateLabel.Text = "Hourly pay rate:";
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSN.Location = new System.Drawing.Point(212, 60);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 20;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(2, 65);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(161, 15);
            this.ssnLabel.TabIndex = 19;
            this.ssnLabel.Text = "Social Security Number:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(212, 33);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 18;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(2, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(114, 15);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Employee name:";
            // 
            // grossPay
            // 
            this.grossPay.AutoSize = true;
            this.grossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPay.Location = new System.Drawing.Point(2, 173);
            this.grossPay.Name = "grossPay";
            this.grossPay.Size = new System.Drawing.Size(68, 13);
            this.grossPay.TabIndex = 25;
            this.grossPay.Text = "Gross Pay:";
            this.grossPay.Click += new System.EventHandler(this.grossPay_Click);
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(212, 166);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(100, 20);
            this.txtGrossPay.TabIndex = 26;
            // 
            // fedTax
            // 
            this.fedTax.AutoSize = true;
            this.fedTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fedTax.Location = new System.Drawing.Point(2, 203);
            this.fedTax.Name = "fedTax";
            this.fedTax.Size = new System.Drawing.Size(78, 13);
            this.fedTax.TabIndex = 27;
            this.fedTax.Text = "Federal Tax:";
            this.fedTax.Click += new System.EventHandler(this.fedTax_Click);
            // 
            // txtFederalTax
            // 
            this.txtFederalTax.Location = new System.Drawing.Point(212, 196);
            this.txtFederalTax.Name = "txtFederalTax";
            this.txtFederalTax.Size = new System.Drawing.Size(100, 20);
            this.txtFederalTax.TabIndex = 28;
            this.txtFederalTax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // stateTax
            // 
            this.stateTax.AutoSize = true;
            this.stateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTax.Location = new System.Drawing.Point(2, 234);
            this.stateTax.Name = "stateTax";
            this.stateTax.Size = new System.Drawing.Size(66, 13);
            this.stateTax.TabIndex = 29;
            this.stateTax.Text = "State Tax:";
            this.stateTax.Click += new System.EventHandler(this.stateTax_Click);
            // 
            // txtStateTax
            // 
            this.txtStateTax.Location = new System.Drawing.Point(212, 227);
            this.txtStateTax.Name = "txtStateTax";
            this.txtStateTax.Size = new System.Drawing.Size(100, 20);
            this.txtStateTax.TabIndex = 30;
            // 
            // netTotal
            // 
            this.netTotal.AutoSize = true;
            this.netTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netTotal.Location = new System.Drawing.Point(84, 298);
            this.netTotal.Name = "netTotal";
            this.netTotal.Size = new System.Drawing.Size(64, 13);
            this.netTotal.TabIndex = 31;
            this.netTotal.Text = "Net Total:";
            // 
            // genarateButton
            // 
            this.genarateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genarateButton.Location = new System.Drawing.Point(77, 331);
            this.genarateButton.Name = "genarateButton";
            this.genarateButton.Size = new System.Drawing.Size(114, 23);
            this.genarateButton.TabIndex = 32;
            this.genarateButton.Text = "Genarate Result:";
            this.genarateButton.UseVisualStyleBackColor = true;
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Location = new System.Drawing.Point(212, 298);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(100, 20);
            this.txtNetTotal.TabIndex = 33;
            // 
            // totalResult
            // 
            this.totalResult.AutoSize = true;
            this.totalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResult.Location = new System.Drawing.Point(212, 340);
            this.totalResult.Name = "totalResult";
            this.totalResult.Size = new System.Drawing.Size(36, 13);
            this.totalResult.TabIndex = 34;
            this.totalResult.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 387);
            this.Controls.Add(this.totalResult);
            this.Controls.Add(this.txtNetTotal);
            this.Controls.Add(this.genarateButton);
            this.Controls.Add(this.netTotal);
            this.Controls.Add(this.txtStateTax);
            this.Controls.Add(this.stateTax);
            this.Controls.Add(this.txtFederalTax);
            this.Controls.Add(this.fedTax);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.grossPay);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.txtHourlyPayRate);
            this.Controls.Add(this.payRateLabel);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.Label payRateLabel;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label grossPay;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label fedTax;
        private System.Windows.Forms.TextBox txtFederalTax;
        private System.Windows.Forms.Label stateTax;
        private System.Windows.Forms.TextBox txtStateTax;
        private System.Windows.Forms.Label netTotal;
        private System.Windows.Forms.Button genarateButton;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Label totalResult;
    }
}

