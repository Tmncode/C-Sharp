namespace EggsInteractiveGUI
{
    partial class eggCalculator
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
            this.txtEggHen1 = new System.Windows.Forms.TextBox();
            this.txtEggHen2 = new System.Windows.Forms.TextBox();
            this.txtEggHen3 = new System.Windows.Forms.TextBox();
            this.txtEggHen4 = new System.Windows.Forms.TextBox();
            this.txtEggHen5 = new System.Windows.Forms.TextBox();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEggHen1
            // 
            this.txtEggHen1.Location = new System.Drawing.Point(36, 50);
            this.txtEggHen1.Name = "txtEggHen1";
            this.txtEggHen1.Size = new System.Drawing.Size(60, 20);
            this.txtEggHen1.TabIndex = 0;
            // 
            // txtEggHen2
            // 
            this.txtEggHen2.Location = new System.Drawing.Point(163, 50);
            this.txtEggHen2.Name = "txtEggHen2";
            this.txtEggHen2.Size = new System.Drawing.Size(66, 20);
            this.txtEggHen2.TabIndex = 1;
            // 
            // txtEggHen3
            // 
            this.txtEggHen3.Location = new System.Drawing.Point(36, 108);
            this.txtEggHen3.Name = "txtEggHen3";
            this.txtEggHen3.Size = new System.Drawing.Size(60, 20);
            this.txtEggHen3.TabIndex = 2;
            // 
            // txtEggHen4
            // 
            this.txtEggHen4.Location = new System.Drawing.Point(163, 107);
            this.txtEggHen4.Name = "txtEggHen4";
            this.txtEggHen4.Size = new System.Drawing.Size(66, 20);
            this.txtEggHen4.TabIndex = 3;
            // 
            // txtEggHen5
            // 
            this.txtEggHen5.Location = new System.Drawing.Point(36, 164);
            this.txtEggHen5.Name = "txtEggHen5";
            this.txtEggHen5.Size = new System.Drawing.Size(60, 20);
            this.txtEggHen5.TabIndex = 4;
            // 
            // calculatorButton
            // 
            this.calculatorButton.Location = new System.Drawing.Point(91, 219);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(190, 23);
            this.calculatorButton.TabIndex = 5;
            this.calculatorButton.Text = "Click to calculate";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // eggCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.txtEggHen5);
            this.Controls.Add(this.txtEggHen4);
            this.Controls.Add(this.txtEggHen3);
            this.Controls.Add(this.txtEggHen2);
            this.Controls.Add(this.txtEggHen1);
            this.Name = "eggCalculator";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEggHen1;
        private System.Windows.Forms.TextBox txtEggHen2;
        private System.Windows.Forms.TextBox txtEggHen3;
        private System.Windows.Forms.TextBox txtEggHen4;
        private System.Windows.Forms.TextBox txtEggHen5;
        private System.Windows.Forms.Button calculatorButton;
        private System.Windows.Forms.Label label1;
    }
}

