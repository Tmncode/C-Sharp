namespace Admission_Office
{
    partial class Admission
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHighSchoolAverage = new System.Windows.Forms.TextBox();
            this.txtAdmission = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "High school grade average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admission test score";
            // 
            // txtHighSchoolAverage
            // 
            this.txtHighSchoolAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighSchoolAverage.Location = new System.Drawing.Point(273, 38);
            this.txtHighSchoolAverage.Name = "txtHighSchoolAverage";
            this.txtHighSchoolAverage.Size = new System.Drawing.Size(100, 22);
            this.txtHighSchoolAverage.TabIndex = 2;
            // 
            // txtAdmission
            // 
            this.txtAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmission.Location = new System.Drawing.Point(273, 93);
            this.txtAdmission.Name = "txtAdmission";
            this.txtAdmission.Size = new System.Drawing.Size(100, 22);
            this.txtAdmission.TabIndex = 3;
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.Location = new System.Drawing.Point(109, 190);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(190, 44);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Click Results";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(106, 316);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 16);
            this.answerLabel.TabIndex = 5;
            // 
            // Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.txtAdmission);
            this.Controls.Add(this.txtHighSchoolAverage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admission";
            this.Text = "Admission Office";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHighSchoolAverage;
        private System.Windows.Forms.TextBox txtAdmission;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label answerLabel;
    }
}

