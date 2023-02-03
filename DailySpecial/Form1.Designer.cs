namespace DailySpecial
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
            this.todaySpecialLabel = new System.Windows.Forms.Label();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.specialButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // todaySpecialLabel
            // 
            this.todaySpecialLabel.AutoSize = true;
            this.todaySpecialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaySpecialLabel.Location = new System.Drawing.Point(97, 62);
            this.todaySpecialLabel.Name = "todaySpecialLabel";
            this.todaySpecialLabel.Size = new System.Drawing.Size(244, 16);
            this.todaySpecialLabel.TabIndex = 0;
            this.todaySpecialLabel.Text = "Enter a day number to see special";
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleLabel.Location = new System.Drawing.Point(128, 125);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(178, 16);
            this.exampleLabel.TabIndex = 1;
            this.exampleLabel.Text = "For example. Sunday = 1";
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(173, 173);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(61, 20);
            this.dayBox.TabIndex = 2;
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(154, 224);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(100, 68);
            this.specialButton.TabIndex = 3;
            this.specialButton.Text = "Get special";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.specialButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(97, 356);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(59, 16);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "display";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.todaySpecialLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todaySpecialLabel;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Button specialButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

