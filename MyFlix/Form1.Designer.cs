namespace MyFlix
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
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Items.AddRange(new object[] {
            "Godzilla",
            "Star Wars",
            "Paper Boy",
            "Chase",
            "Home Alone 3",
            "Jack & Jill"});
            this.movieListBox.Location = new System.Drawing.Point(15, 53);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.movieListBox.Size = new System.Drawing.Size(93, 82);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.movieListBox_SelectedIndexChanged);
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(12, 157);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(303, 23);
            this.priceButton.TabIndex = 1;
            this.priceButton.Text = "Calcalution";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(28, 13);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(248, 26);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "You can choose as many downloads as you like by\r\nholding down the Ctrl key while " +
    "making selections\r\n";
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(9, 196);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(74, 13);
            this.movieLabel.TabIndex = 3;
            this.movieLabel.Text = "Your selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 230);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.movieListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label movieLabel;
    }
}

