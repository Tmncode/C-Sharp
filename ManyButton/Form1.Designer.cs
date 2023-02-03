namespace ManyButton
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
            this.redButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(13, 13);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(75, 23);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.Location = new System.Drawing.Point(95, 12);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(75, 23);
            this.whiteButton.TabIndex = 1;
            this.whiteButton.Text = "White";
            this.whiteButton.UseVisualStyleBackColor = true;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(177, 11);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(75, 23);
            this.blueButton.TabIndex = 2;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Location = new System.Drawing.Point(13, 53);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(239, 23);
            this.favoriteButton.TabIndex = 3;
            this.favoriteButton.Text = "My favorite color";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 91);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.redButton);
            this.Name = "Form1";
            this.Text = "Many Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button favoriteButton;
    }
}

