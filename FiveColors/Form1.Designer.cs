namespace FiveColors
{
    partial class changeColorForm
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
            this.changeColorButton1 = new System.Windows.Forms.Button();
            this.changeColorButton2 = new System.Windows.Forms.Button();
            this.changeColorButton3 = new System.Windows.Forms.Button();
            this.changeColorButton4 = new System.Windows.Forms.Button();
            this.changeColorButton5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeColorButton1
            // 
            this.changeColorButton1.BackColor = System.Drawing.Color.Blue;
            this.changeColorButton1.Location = new System.Drawing.Point(28, 48);
            this.changeColorButton1.Name = "changeColorButton1";
            this.changeColorButton1.Size = new System.Drawing.Size(75, 23);
            this.changeColorButton1.TabIndex = 0;
            this.changeColorButton1.Text = "Blue";
            this.changeColorButton1.UseVisualStyleBackColor = false;
            this.changeColorButton1.Click += new System.EventHandler(this.changeColorButton1_Click);
            // 
            // changeColorButton2
            // 
            this.changeColorButton2.BackColor = System.Drawing.Color.Yellow;
            this.changeColorButton2.Location = new System.Drawing.Point(28, 93);
            this.changeColorButton2.Name = "changeColorButton2";
            this.changeColorButton2.Size = new System.Drawing.Size(75, 23);
            this.changeColorButton2.TabIndex = 1;
            this.changeColorButton2.Text = "Yellow";
            this.changeColorButton2.UseVisualStyleBackColor = false;
            this.changeColorButton2.Click += new System.EventHandler(this.changeColorButton2_Click);
            // 
            // changeColorButton3
            // 
            this.changeColorButton3.BackColor = System.Drawing.Color.Red;
            this.changeColorButton3.Location = new System.Drawing.Point(28, 141);
            this.changeColorButton3.Name = "changeColorButton3";
            this.changeColorButton3.Size = new System.Drawing.Size(75, 23);
            this.changeColorButton3.TabIndex = 2;
            this.changeColorButton3.Text = "Red";
            this.changeColorButton3.UseVisualStyleBackColor = false;
            this.changeColorButton3.Click += new System.EventHandler(this.changeColorButton3_Click);
            // 
            // changeColorButton4
            // 
            this.changeColorButton4.BackColor = System.Drawing.Color.Lime;
            this.changeColorButton4.Location = new System.Drawing.Point(28, 187);
            this.changeColorButton4.Name = "changeColorButton4";
            this.changeColorButton4.Size = new System.Drawing.Size(75, 23);
            this.changeColorButton4.TabIndex = 3;
            this.changeColorButton4.Text = "Lime";
            this.changeColorButton4.UseVisualStyleBackColor = false;
            this.changeColorButton4.Click += new System.EventHandler(this.changeColorButton4_Click);
            // 
            // changeColorButton5
            // 
            this.changeColorButton5.BackColor = System.Drawing.Color.Purple;
            this.changeColorButton5.Location = new System.Drawing.Point(28, 229);
            this.changeColorButton5.Name = "changeColorButton5";
            this.changeColorButton5.Size = new System.Drawing.Size(75, 23);
            this.changeColorButton5.TabIndex = 4;
            this.changeColorButton5.Text = "Purple";
            this.changeColorButton5.UseVisualStyleBackColor = false;
            this.changeColorButton5.Click += new System.EventHandler(this.changeColorButton5_Click);
            // 
            // changeColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(306, 292);
            this.Controls.Add(this.changeColorButton5);
            this.Controls.Add(this.changeColorButton4);
            this.Controls.Add(this.changeColorButton3);
            this.Controls.Add(this.changeColorButton2);
            this.Controls.Add(this.changeColorButton1);
            this.Name = "changeColorForm";
            this.Text = "Change Color";
            this.Load += new System.EventHandler(this.changeColorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeColorButton1;
        private System.Windows.Forms.Button changeColorButton2;
        private System.Windows.Forms.Button changeColorButton3;
        private System.Windows.Forms.Button changeColorButton4;
        private System.Windows.Forms.Button changeColorButton5;
    }
}

