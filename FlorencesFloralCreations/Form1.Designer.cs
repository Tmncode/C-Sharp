namespace FlorencesFloralCreations
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
            this.lstFlowers = new System.Windows.Forms.ListBox();
            this.lstOccasions = new System.Windows.Forms.ListBox();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFlowers
            // 
            this.lstFlowers.FormattingEnabled = true;
            this.lstFlowers.ItemHeight = 21;
            this.lstFlowers.Items.AddRange(new object[] {
            "Red Roses",
            "Pink snapdragons",
            "Poppy",
            "Daisy",
            "Blanketflower",
            "Iris"});
            this.lstFlowers.Location = new System.Drawing.Point(20, 262);
            this.lstFlowers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstFlowers.Name = "lstFlowers";
            this.lstFlowers.Size = new System.Drawing.Size(238, 172);
            this.lstFlowers.TabIndex = 0;
            this.lstFlowers.SelectedIndexChanged += new System.EventHandler(this.lstFlowers_SelectedIndexChanged);
            // 
            // lstOccasions
            // 
            this.lstOccasions.FormattingEnabled = true;
            this.lstOccasions.ItemHeight = 21;
            this.lstOccasions.Items.AddRange(new object[] {
            "Wedding",
            "Prom",
            "ValentineDay"});
            this.lstOccasions.Location = new System.Drawing.Point(21, 21);
            this.lstOccasions.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstOccasions.Name = "lstOccasions";
            this.lstOccasions.Size = new System.Drawing.Size(235, 172);
            this.lstOccasions.TabIndex = 1;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.Location = new System.Drawing.Point(370, 349);
            this.lblCongrats.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(0, 30);
            this.lblCongrats.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 462);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.lstOccasions);
            this.Controls.Add(this.lstFlowers);
            this.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFlowers;
        private System.Windows.Forms.ListBox lstOccasions;
        private System.Windows.Forms.Label lblCongrats;
    }
}

