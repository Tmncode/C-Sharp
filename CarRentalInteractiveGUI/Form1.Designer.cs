namespace CarRentalInteractiveGUI
{
    partial class CarRentalInteractive
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
            this.num = new System.Windows.Forms.Label();
            this.txtNbrOfDays = new System.Windows.Forms.TextBox();
            this.totalMiles = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.feeDays = new System.Windows.Forms.Label();
            this.feeMiles = new System.Windows.Forms.Label();
            this.txtFeePerDay = new System.Windows.Forms.TextBox();
            this.txtFeePerMile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(13, 40);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(145, 16);
            this.num.TabIndex = 0;
            this.num.Text = "Enter a number of days";
            // 
            // txtNbrOfDays
            // 
            this.txtNbrOfDays.Location = new System.Drawing.Point(219, 36);
            this.txtNbrOfDays.Name = "txtNbrOfDays";
            this.txtNbrOfDays.Size = new System.Drawing.Size(100, 20);
            this.txtNbrOfDays.TabIndex = 1;
            // 
            // totalMiles
            // 
            this.totalMiles.AutoSize = true;
            this.totalMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMiles.Location = new System.Drawing.Point(16, 73);
            this.totalMiles.Name = "totalMiles";
            this.totalMiles.Size = new System.Drawing.Size(74, 16);
            this.totalMiles.TabIndex = 2;
            this.totalMiles.Text = "Enter miles";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(219, 68);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(19, 173);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(194, 23);
            this.Enter.TabIndex = 6;
            this.Enter.Text = "Enter Here";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // feeDays
            // 
            this.feeDays.AutoSize = true;
            this.feeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeDays.Location = new System.Drawing.Point(16, 103);
            this.feeDays.Name = "feeDays";
            this.feeDays.Size = new System.Drawing.Size(90, 16);
            this.feeDays.TabIndex = 8;
            this.feeDays.Text = "Fee per Days";
            // 
            // feeMiles
            // 
            this.feeMiles.AutoSize = true;
            this.feeMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeMiles.Location = new System.Drawing.Point(16, 132);
            this.feeMiles.Name = "feeMiles";
            this.feeMiles.Size = new System.Drawing.Size(90, 16);
            this.feeMiles.TabIndex = 9;
            this.feeMiles.Text = "Fee per Miles";
            // 
            // txtFeePerDay
            // 
            this.txtFeePerDay.Location = new System.Drawing.Point(219, 103);
            this.txtFeePerDay.Name = "txtFeePerDay";
            this.txtFeePerDay.Size = new System.Drawing.Size(100, 20);
            this.txtFeePerDay.TabIndex = 10;
            // 
            // txtFeePerMile
            // 
            this.txtFeePerMile.Location = new System.Drawing.Point(219, 132);
            this.txtFeePerMile.Name = "txtFeePerMile";
            this.txtFeePerMile.Size = new System.Drawing.Size(100, 20);
            this.txtFeePerMile.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // CarRentalInteractive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFeePerMile);
            this.Controls.Add(this.txtFeePerDay);
            this.Controls.Add(this.feeMiles);
            this.Controls.Add(this.feeDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.totalMiles);
            this.Controls.Add(this.txtNbrOfDays);
            this.Controls.Add(this.num);
            this.Name = "CarRentalInteractive";
            this.Text = "CarRental";
            this.Load += new System.EventHandler(this.CarRentalInteractive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num;
        private System.Windows.Forms.TextBox txtNbrOfDays;
        private System.Windows.Forms.Label totalMiles;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label feeDays;
        private System.Windows.Forms.Label feeMiles;
        private System.Windows.Forms.TextBox txtFeePerDay;
        private System.Windows.Forms.TextBox txtFeePerMile;
        private System.Windows.Forms.Label label1;
    }
}

