namespace BedAndBreakfast
{
    partial class LincolnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LincolnForm));
            this.lincolnDescriptionLabel = new System.Windows.Forms.Label();
            this.lincolnPriceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lincolnDescriptionLabel
            // 
            this.lincolnDescriptionLabel.AutoSize = true;
            this.lincolnDescriptionLabel.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnDescriptionLabel.Location = new System.Drawing.Point(26, 9);
            this.lincolnDescriptionLabel.Name = "lincolnDescriptionLabel";
            this.lincolnDescriptionLabel.Size = new System.Drawing.Size(231, 42);
            this.lincolnDescriptionLabel.TabIndex = 0;
            this.lincolnDescriptionLabel.Text = "Return to the 1850s in this lovely\r\nroom with private bath.";
            // 
            // lincolnPriceLabel
            // 
            this.lincolnPriceLabel.AutoSize = true;
            this.lincolnPriceLabel.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnPriceLabel.Location = new System.Drawing.Point(179, 153);
            this.lincolnPriceLabel.Name = "lincolnPriceLabel";
            this.lincolnPriceLabel.Size = new System.Drawing.Size(109, 21);
            this.lincolnPriceLabel.TabIndex = 1;
            this.lincolnPriceLabel.Text = "$110 per night.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 159);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LincolnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lincolnPriceLabel);
            this.Controls.Add(this.lincolnDescriptionLabel);
            this.Name = "LincolnForm";
            this.Text = "Lincoln Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lincolnDescriptionLabel;
        private System.Windows.Forms.Label lincolnPriceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}