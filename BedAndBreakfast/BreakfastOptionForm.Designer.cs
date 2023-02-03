namespace BedAndBreakfast
{
    partial class BreakfastOptionForm
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
            this.breakfastlabel = new System.Windows.Forms.Label();
            this.conBreakfastButton = new System.Windows.Forms.RadioButton();
            this.fullBreakfastButton = new System.Windows.Forms.RadioButton();
            this.deluxeBreakfastButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breakfastlabel
            // 
            this.breakfastlabel.AutoSize = true;
            this.breakfastlabel.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastlabel.Location = new System.Drawing.Point(40, 13);
            this.breakfastlabel.Name = "breakfastlabel";
            this.breakfastlabel.Size = new System.Drawing.Size(349, 38);
            this.breakfastlabel.TabIndex = 0;
            this.breakfastlabel.Text = "Select your breakfast option.";
            this.breakfastlabel.Click += new System.EventHandler(this.breakfastlabel_Click);
            // 
            // conBreakfastButton
            // 
            this.conBreakfastButton.AutoSize = true;
            this.conBreakfastButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conBreakfastButton.Location = new System.Drawing.Point(43, 81);
            this.conBreakfastButton.Name = "conBreakfastButton";
            this.conBreakfastButton.Size = new System.Drawing.Size(98, 25);
            this.conBreakfastButton.TabIndex = 1;
            this.conBreakfastButton.TabStop = true;
            this.conBreakfastButton.Text = "Continental";
            this.conBreakfastButton.UseVisualStyleBackColor = true;
            this.conBreakfastButton.CheckedChanged += new System.EventHandler(this.conBreakfastButton_CheckedChanged);
            // 
            // fullBreakfastButton
            // 
            this.fullBreakfastButton.AutoSize = true;
            this.fullBreakfastButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBreakfastButton.Location = new System.Drawing.Point(43, 128);
            this.fullBreakfastButton.Name = "fullBreakfastButton";
            this.fullBreakfastButton.Size = new System.Drawing.Size(51, 25);
            this.fullBreakfastButton.TabIndex = 2;
            this.fullBreakfastButton.TabStop = true;
            this.fullBreakfastButton.Text = "Full";
            this.fullBreakfastButton.UseVisualStyleBackColor = true;
            this.fullBreakfastButton.CheckedChanged += new System.EventHandler(this.fullBreakfastButton_CheckedChanged);
            // 
            // deluxeBreakfastButton
            // 
            this.deluxeBreakfastButton.AutoSize = true;
            this.deluxeBreakfastButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluxeBreakfastButton.Location = new System.Drawing.Point(43, 175);
            this.deluxeBreakfastButton.Name = "deluxeBreakfastButton";
            this.deluxeBreakfastButton.Size = new System.Drawing.Size(72, 25);
            this.deluxeBreakfastButton.TabIndex = 3;
            this.deluxeBreakfastButton.TabStop = true;
            this.deluxeBreakfastButton.Text = "Deluxe";
            this.deluxeBreakfastButton.UseVisualStyleBackColor = true;
            this.deluxeBreakfastButton.CheckedChanged += new System.EventHandler(this.deluxeBreakfastButton_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(223, 216);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(416, 273);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.deluxeBreakfastButton);
            this.Controls.Add(this.fullBreakfastButton);
            this.Controls.Add(this.conBreakfastButton);
            this.Controls.Add(this.breakfastlabel);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label breakfastlabel;
        private System.Windows.Forms.RadioButton conBreakfastButton;
        private System.Windows.Forms.RadioButton fullBreakfastButton;
        private System.Windows.Forms.RadioButton deluxeBreakfastButton;
        private System.Windows.Forms.Label priceLabel;
    }
}