namespace MonthNameGUI
{
    partial class MonthsLabel
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
            this.labelMonthNum = new System.Windows.Forms.Label();
            this.txtMonthNum = new System.Windows.Forms.TextBox();
            this.butComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMonthNum
            // 
            this.labelMonthNum.AutoSize = true;
            this.labelMonthNum.Location = new System.Drawing.Point(25, 35);
            this.labelMonthNum.Name = "labelMonthNum";
            this.labelMonthNum.Size = new System.Drawing.Size(123, 13);
            this.labelMonthNum.TabIndex = 0;
            this.labelMonthNum.Text = "Enter Month Number";
            // 
            // txtMonthNum
            // 
            this.txtMonthNum.Location = new System.Drawing.Point(222, 28);
            this.txtMonthNum.Name = "txtMonthNum";
            this.txtMonthNum.Size = new System.Drawing.Size(100, 20);
            this.txtMonthNum.TabIndex = 1;
            // 
            // butComplete
            // 
            this.butComplete.Location = new System.Drawing.Point(152, 118);
            this.butComplete.Name = "butComplete";
            this.butComplete.Size = new System.Drawing.Size(75, 23);
            this.butComplete.TabIndex = 2;
            this.butComplete.Text = "Complete";
            this.butComplete.UseVisualStyleBackColor = true;
            this.butComplete.Click += new System.EventHandler(this.butComplete_Click);
            // 
            // MonthsLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 221);
            this.Controls.Add(this.butComplete);
            this.Controls.Add(this.txtMonthNum);
            this.Controls.Add(this.labelMonthNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MonthsLabel";
            this.Text = "Months";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMonthNum;
        private System.Windows.Forms.TextBox txtMonthNum;
        private System.Windows.Forms.Button butComplete;
    }
}

