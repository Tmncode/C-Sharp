namespace GuessANumber
{
    partial class GuessANumber
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
            this.radOne = new System.Windows.Forms.RadioButton();
            this.radTwo = new System.Windows.Forms.RadioButton();
            this.radThree = new System.Windows.Forms.RadioButton();
            this.radFour = new System.Windows.Forms.RadioButton();
            this.radFive = new System.Windows.Forms.RadioButton();
            this.lblHint = new System.Windows.Forms.Label();
            this.grpRad = new System.Windows.Forms.GroupBox();
            this.grpRad.SuspendLayout();
            this.SuspendLayout();
            // 
            // radOne
            // 
            this.radOne.AutoSize = true;
            this.radOne.Location = new System.Drawing.Point(7, 20);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(45, 17);
            this.radOne.TabIndex = 0;
            this.radOne.TabStop = true;
            this.radOne.Text = "One";
            this.radOne.UseVisualStyleBackColor = true;
            this.radOne.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radTwo
            // 
            this.radTwo.AutoSize = true;
            this.radTwo.Location = new System.Drawing.Point(7, 44);
            this.radTwo.Name = "radTwo";
            this.radTwo.Size = new System.Drawing.Size(46, 17);
            this.radTwo.TabIndex = 1;
            this.radTwo.TabStop = true;
            this.radTwo.Text = "Two";
            this.radTwo.UseVisualStyleBackColor = true;
            this.radTwo.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radThree
            // 
            this.radThree.AutoSize = true;
            this.radThree.Location = new System.Drawing.Point(7, 68);
            this.radThree.Name = "radThree";
            this.radThree.Size = new System.Drawing.Size(53, 17);
            this.radThree.TabIndex = 2;
            this.radThree.TabStop = true;
            this.radThree.Text = "Three";
            this.radThree.UseVisualStyleBackColor = true;
            this.radThree.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radFour
            // 
            this.radFour.AutoSize = true;
            this.radFour.Location = new System.Drawing.Point(7, 92);
            this.radFour.Name = "radFour";
            this.radFour.Size = new System.Drawing.Size(46, 17);
            this.radFour.TabIndex = 3;
            this.radFour.TabStop = true;
            this.radFour.Text = "Four";
            this.radFour.UseVisualStyleBackColor = true;
            this.radFour.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radFive
            // 
            this.radFive.AutoSize = true;
            this.radFive.Location = new System.Drawing.Point(7, 116);
            this.radFive.Name = "radFive";
            this.radFive.Size = new System.Drawing.Size(45, 17);
            this.radFive.TabIndex = 4;
            this.radFive.TabStop = true;
            this.radFive.Text = "Five";
            this.radFive.UseVisualStyleBackColor = true;
            this.radFive.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.Black;
            this.lblHint.Location = new System.Drawing.Point(262, 77);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(57, 20);
            this.lblHint.TabIndex = 5;
            this.lblHint.Text = "label1";
            // 
            // grpRad
            // 
            this.grpRad.BackColor = System.Drawing.Color.DarkGray;
            this.grpRad.Controls.Add(this.radOne);
            this.grpRad.Controls.Add(this.radTwo);
            this.grpRad.Controls.Add(this.radFive);
            this.grpRad.Controls.Add(this.radThree);
            this.grpRad.Controls.Add(this.radFour);
            this.grpRad.Location = new System.Drawing.Point(12, 12);
            this.grpRad.Name = "grpRad";
            this.grpRad.Size = new System.Drawing.Size(200, 142);
            this.grpRad.TabIndex = 6;
            this.grpRad.TabStop = false;
            // 
            // GuessANumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 173);
            this.Controls.Add(this.grpRad);
            this.Controls.Add(this.lblHint);
            this.Name = "GuessANumber";
            this.Text = "Guess A Number";
            this.grpRad.ResumeLayout(false);
            this.grpRad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radOne;
        private System.Windows.Forms.RadioButton radTwo;
        private System.Windows.Forms.RadioButton radThree;
        private System.Windows.Forms.RadioButton radFour;
        private System.Windows.Forms.RadioButton radFive;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.GroupBox grpRad;
    }
}

