namespace PayrollGUI
{
    partial class payrollForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.hourlyPayRate = new System.Windows.Forms.Label();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.hoursWorked = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.fedTax = new System.Windows.Forms.Label();
            this.txtFedTax = new System.Windows.Forms.TextBox();
            this.stateTax = new System.Windows.Forms.Label();
            this.txtStateTax = new System.Windows.Forms.TextBox();
            this.netPayButton = new System.Windows.Forms.Button();
            this.grossTotalPay = new System.Windows.Forms.Label();
            this.txtTotalGross = new System.Windows.Forms.TextBox();
            this.netPayTotal = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(31, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(216, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(31, 68);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(73, 15);
            this.ssnLabel.TabIndex = 2;
            this.ssnLabel.Text = "EnterSSN:";
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSN.Location = new System.Drawing.Point(216, 63);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 3;
            // 
            // hourlyPayRate
            // 
            this.hourlyPayRate.AutoSize = true;
            this.hourlyPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayRate.Location = new System.Drawing.Point(31, 95);
            this.hourlyPayRate.Name = "hourlyPayRate";
            this.hourlyPayRate.Size = new System.Drawing.Size(107, 15);
            this.hourlyPayRate.TabIndex = 4;
            this.hourlyPayRate.Text = "Hourly pay rate:";
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyPayRate.Location = new System.Drawing.Point(216, 90);
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyPayRate.TabIndex = 5;
            // 
            // hoursWorked
            // 
            this.hoursWorked.AutoSize = true;
            this.hoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorked.Location = new System.Drawing.Point(31, 123);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(101, 15);
            this.hoursWorked.TabIndex = 6;
            this.hoursWorked.Text = "Hours Worked:";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(216, 116);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 7;
            // 
            // fedTax
            // 
            this.fedTax.AutoSize = true;
            this.fedTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fedTax.Location = new System.Drawing.Point(31, 214);
            this.fedTax.Name = "fedTax";
            this.fedTax.Size = new System.Drawing.Size(187, 15);
            this.fedTax.TabIndex = 10;
            this.fedTax.Text = "Federal Withholding Tax .15";
            // 
            // txtFedTax
            // 
            this.txtFedTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFedTax.Location = new System.Drawing.Point(234, 209);
            this.txtFedTax.Name = "txtFedTax";
            this.txtFedTax.Size = new System.Drawing.Size(100, 20);
            this.txtFedTax.TabIndex = 11;
            // 
            // stateTax
            // 
            this.stateTax.AutoSize = true;
            this.stateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTax.Location = new System.Drawing.Point(31, 242);
            this.stateTax.Name = "stateTax";
            this.stateTax.Size = new System.Drawing.Size(171, 15);
            this.stateTax.TabIndex = 12;
            this.stateTax.Text = "State Withholding Tax .05";
            // 
            // txtStateTax
            // 
            this.txtStateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateTax.Location = new System.Drawing.Point(234, 237);
            this.txtStateTax.Name = "txtStateTax";
            this.txtStateTax.Size = new System.Drawing.Size(100, 20);
            this.txtStateTax.TabIndex = 13;
            // 
            // netPayButton
            // 
            this.netPayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPayButton.Location = new System.Drawing.Point(273, 382);
            this.netPayButton.Name = "netPayButton";
            this.netPayButton.Size = new System.Drawing.Size(171, 56);
            this.netPayButton.TabIndex = 15;
            this.netPayButton.Text = "Net Pay Result";
            this.netPayButton.UseVisualStyleBackColor = true;
            this.netPayButton.Click += new System.EventHandler(this.netPayButton_Click_1);
            // 
            // grossTotalPay
            // 
            this.grossTotalPay.AutoSize = true;
            this.grossTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossTotalPay.Location = new System.Drawing.Point(34, 185);
            this.grossTotalPay.Name = "grossTotalPay";
            this.grossTotalPay.Size = new System.Drawing.Size(101, 13);
            this.grossTotalPay.TabIndex = 16;
            this.grossTotalPay.Text = "Gross Total Pay:";
            // 
            // txtTotalGross
            // 
            this.txtTotalGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGross.Location = new System.Drawing.Point(234, 178);
            this.txtTotalGross.Name = "txtTotalGross";
            this.txtTotalGross.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGross.TabIndex = 17;
            // 
            // netPayTotal
            // 
            this.netPayTotal.AutoSize = true;
            this.netPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPayTotal.Location = new System.Drawing.Point(154, 290);
            this.netPayTotal.Name = "netPayTotal";
            this.netPayTotal.Size = new System.Drawing.Size(64, 13);
            this.netPayTotal.TabIndex = 18;
            this.netPayTotal.Text = "Net Total:";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.Location = new System.Drawing.Point(234, 283);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(100, 20);
            this.txtNetPay.TabIndex = 19;
            // 
            // payrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.netPayTotal);
            this.Controls.Add(this.txtTotalGross);
            this.Controls.Add(this.grossTotalPay);
            this.Controls.Add(this.netPayButton);
            this.Controls.Add(this.txtStateTax);
            this.Controls.Add(this.stateTax);
            this.Controls.Add(this.txtFedTax);
            this.Controls.Add(this.fedTax);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.txtHourlyPayRate);
            this.Controls.Add(this.hourlyPayRate);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.nameLabel);
            this.Name = "payrollForm";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.payrollForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label hourlyPayRate;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.Label hoursWorked;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label fedTax;
        private System.Windows.Forms.TextBox txtFedTax;
        private System.Windows.Forms.Label stateTax;
        private System.Windows.Forms.TextBox txtStateTax;
        private System.Windows.Forms.Button netPayButton;
        private System.Windows.Forms.Label grossTotalPay;
        private System.Windows.Forms.TextBox txtTotalGross;
        private System.Windows.Forms.Label netPayTotal;
        private System.Windows.Forms.TextBox txtNetPay;
    }
}

